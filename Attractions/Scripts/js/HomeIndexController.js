//HomeIndexController.js

(function() {

    "use strict";

    angular.module("app").controller("HomeIndexController", homeIndexController);

    function homeIndexController($scope, $http, dataService, toastr) {

        $scope.search = "";
        $scope.Continent = "All";
        $scope.Attractions = [];
        $scope.Favourites = [];
        $scope.totalAttractions = 0;
        $scope.filteredAttractions = [];

        dataService.getAllAttractions()
            .then(function (response) {
                // Success
                $scope.Attractions = response.data;
                $scope.totalAttractions = $scope.Attractions.length;
                //updateView();
            }, function (data, status, header, config) {
                // Failure
                console.log("error :" + data + "   status:" + status + "   header:" + header + "   config:" + config);
            });

        $scope.Favourites = dataService.getFavourites();

        $scope.searchAttractions = function(searchText) {
            $scope.Attractions = dataService.findAttractions(searchText);
        }

        //change to use | filter in view
        $scope.filterAttractionsByContinent = function(continent) {
            if (continent === "All") {
                $scope.Attractions = dataService.getAllAttractions();
            } else {
                $scope.Attractions = dataService.findAttractionsInContinent(continent);
            }
        }

        $scope.addToFavourites = function (id) { 
            dataService.addToFavourites(id)
                .success(function (response) {
                    // Success
                    dataService.findAttractionById(id)
                        .then(function (response) {
                            // Success
                            toastr.success('Successfully added to Favourites', response.data.title + ' ' + response.data.type);
                        }, function (data, status, header, config) {
                            // Failure
                            console.log("error :" + data + "   status:" + status + "   header:" + header + "   config:" + config);
                        });  

                    $scope.Favourites = dataService.getFavourites();
                })
                .error(function (data, status, header, config) {
                    console.log("error :" + data + "   status:" + status + "   header:" + header + "   config:" + config);
                });            
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


        // Pagination
        $scope.itemsPerPage = 12;
        $scope.currentPage = 1;

        $scope.pageCount = function () {
            return Math.ceil($scope.Attractions / $scope.itemsPerPage);
        };

        //$scope.$watch('currentPage + itemsPerPage', function () {
        //    updateView();
        //});

        //function updateView() {
        //    var begin = (($scope.currentPage - 1) * $scope.itemsPerPage),
        //    end = begin + $scope.itemsPerPage;

        //    $scope.filteredAttractions = $scope.Attractions.slice(begin, end);
        //}


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
