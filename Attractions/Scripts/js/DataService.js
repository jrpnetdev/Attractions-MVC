//DataService.js

(function() {

    "use strict";

    angular.module("app").factory("dataService", dataService);

    function dataService($http) {

        var attractions = [];
        var featured = [];
        var favourites = [];
        
        return {
            getAllAttractions: getAllAttractions,
            getFeaturedAttractions: getFeaturedAttractions,
            findAttractions: findAttractions,
            findAttractionsInContinent: findAttractionsInContinent,
            getFavourites: getFavourites,
            addToFavourites: addToFavourites
        }

        function getAllAttractions() {
            
            $http.get("/api/v1/attractions")
                .then(function (response) {
                    // Success
                    angular.copy(response.data, attractions);
                }, function () {
                    // Failure
            });
            return attractions;
        }

        function getFeaturedAttractions() {
            
            $http.get("/api/v1/featured")
                .then(function (response) {
                    // Success
                    angular.copy(response.data, featured);
                }, function () {
                    // Failure
            });
            return featured;
        }

        function findAttractions(searchText) {

            $http.get("/api/v1/attractions?searchText=" + searchText)
                .then(function (response) {
                    // Success
                    angular.copy(response.data, attractions);
                }, function () {
                    // Failure
                });
            return attractions;
        }

        function findAttractionsInContinent(continent) {

            $http.get("/api/v1/attractions?id=1&continent=" + continent)
                .then(function (response) {
                    // Success
                    angular.copy(response.data, attractions);
                }, function () {
                    // Failure
                });
            return attractions;
        }

        function getFavourites() {

            $http.get("/api/v1/favourites")
                .then(function (response) {
                    // Success
                    angular.copy(response.data, favourites);
                }, function () {
                    // Failure
            });
            return favourites;
        }

        function addToFavourites(id) {
            $http.post("/api/v1/favourites/" + id)
                .success(function(response) {
                    // Success
                })
                .error(function (data, status, header, config) {
                    console.log("error :" + data + "   status:" + status + "   header:" + header + "   config:" + config);
                });
        }
    }

})();