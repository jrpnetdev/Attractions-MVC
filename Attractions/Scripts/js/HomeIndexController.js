//HomeIndexController.js

(function() {

    "use strict";

    angular.module("app").controller("HomeIndexController", homeIndexController);

    function homeIndexController($scope, dataService) {

        $scope.search = "";
        $scope.Attractions = [];
        $scope.Favourites = [];

        $scope.Attractions = dataService.getAllAttractions();
        $scope.Favourites = dataService.getFavourites();

        $scope.searchAttractions = function (searchText) {
            $scope.Attractions = dataService.findAttractions(searchText);
        }

        $scope.addToFavourites = function (id) {
            dataService.addToFavourites(id);
            $scope.Favourites = dataService.getFavourites();
        }

        $scope.removeFromFavourites = function (id) {
            dataService.removeFromFavourites(id);
            $scope.Favourites = dataService.getFavourites();
            console.log(id);
        }

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
