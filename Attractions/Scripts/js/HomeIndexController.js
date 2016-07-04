//HomeIndexController.js

(function() {

    "use strict";

    angular.module("app").controller("HomeIndexController", homeIndexController);

    function homeIndexController($scope, dataService) {

        $scope.search = "";
        $scope.Attractions = [];
        $scope.Favourites = [];

        $scope.addToFavourites = function() {
            //TODO

            var attractionId = this.attraction.id;
            //$http.post("/api/v1/attractions/" + attractionId)...

            console.log(this.attraction.id);
        }

        $scope.Attractions = dataService.getAllAttractions();

        $scope.searchAttractions = function (searchText) {
            $scope.Attractions = dataService.findAttractions(searchText);
        }

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
