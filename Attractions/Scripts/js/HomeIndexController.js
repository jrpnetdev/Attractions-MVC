//HomeIndexController.js

(function() {

    "use strict";

    angular.module("app").controller("HomeIndexController", homeIndexController);

    function homeIndexController($scope, $http, dataService) {

        $scope.search = "";
        $scope.Continent = "All";
        $scope.Attractions = [];
        $scope.Favourites = [];
        $scope.totalAttractions = 0;

        dataService.getAllAttractions()
            .then(function (response) {
                // Success
                $scope.Attractions = response.data;
                $scope.totalAttractions = $scope.Attractions.length;
            }, function () {
                // Failure
            });

        $scope.Favourites = dataService.getFavourites();

        $scope.searchAttractions = function(searchText) {
            $scope.Attractions = dataService.findAttractions(searchText);
        }

        $scope.filterAttractionsByContinent = function(continent) {
            if (continent === "All") {
                $scope.Attractions = dataService.getAllAttractions();
            } else {
                $scope.Attractions = dataService.findAttractionsInContinent(continent);
            }
        }

        $scope.addToFavourites = function(id) {
            dataService.addToFavourites(id);
            $scope.Favourites = dataService.getFavourites();
        }

        $scope.removeFromFavourites = function(id) {
            $http.delete("/api/v1/favourites/" + id)
                .success(function(response) {
                    // Success
                    $scope.Favourites = dataService.getFavourites();
                })
                .error(function(data, status, header, config) {
                    // Failure
                    console.log("error :" + data + "   status:" + status + "   header:" + header + "   config:" + config);
                });
        }

        $scope.sortOrder = "id";

        // Slick Slider breakpoints
        $scope.breakpoints = [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3
                }
            },
            {
                breakpoint: 650,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ];
    }

})();
