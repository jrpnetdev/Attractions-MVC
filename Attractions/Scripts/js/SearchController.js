//SearchController.js

(function () {

    "use strict";

    angular.module("app").controller("SearchController", searchController);

    function searchController($scope, dataService) {

        $scope.search = "";
        $scope.Attractions = [];
        $scope.Favourites = [];

        $scope.Attractions = dataService.getAllAttractions();
        $scope.Favourites = dataService.getFavourites();

        $scope.searchAttractions = function(searchText) {
            $scope.Attractions = dataService.findAttractions(searchText);
        }

        $scope.addToFavourites = function(id) {

            dataService.addToFavourites(id);
            $scope.Favourites = dataService.getFavourites();

            console.log(id);
        }

    }

})();