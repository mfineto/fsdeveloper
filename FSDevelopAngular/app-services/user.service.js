(function () {
    'use strict';

    angular
        .module('app')
        .factory('UserService', UserService);

    UserService.$inject = ['$http', '$rootScope'];
    function UserService($http, $rootScope) {
        var service = {};

        service.RetrieveAllProducts = RetrieveAllProducts;

        return service;

        function GetAll(callback) {
            delete $http.defaults.headers.common['X-Requested-With'];
            $http.defaults.useXDomain = true;
            $http.defaults.headers.common['Access-Control-Allow-Origin'] = '*';

            $http({method: 'GET', 
                url: 'http://localhost:5000/api/product/products',
                headers: {'Content-Type': 'application/json'}
            })
            .then(function(response) {
                console.log(response);
                SetCredentials(username, response.data.accessToken);
                response.success = true;
                callback(response);
            }, 
            function(response) {
                console.log(response);
                response = { success: false, message: 'Username or password is incorrect' };
                callback(response);
            });
        }

        function RetrieveAllProducts(callback) {
            //var products = $http.get('http://localhost:5000/api/product/products').then(handleSuccess, handleError('Error getting all users'));
            
            delete $http.defaults.headers.common['X-Requested-With'];
            $http.defaults.useXDomain = true;
            $http.defaults.headers.common['Access-Control-Allow-Origin'] = '*';

            $http({method: 'GET', 
                url: 'http://localhost:5000/api/product/products',
                headers: {'Content-Type': 'application/json',
                         'Authorization': 'Bearer ' + $rootScope.globals.currentUser.authdata }
            })
            .then(function(response) {
                callback(response);
            }, 
            function(response) {
                response = { success: false, message: 'Error getting all products' };
                callback(response);
            });
        }

        // private functions

        function handleSuccess(res) {
            return res.data;
        }

        function handleError(error) {
            return function () {
                return { success: false, message: error };
            };
        }
    }

})();
