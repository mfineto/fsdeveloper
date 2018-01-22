(function () {
    'use strict';

    angular
        .module('app')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['UserService', '$rootScope'];
    function HomeController(UserService, $rootScope) {
        var vm = this;

        vm.products = null;

        initController();

        function initController() {
            loadProducts();
        }

        function loadProducts() {
            vm.dataLoading = true;
            UserService.RetrieveAllProducts(function (response) {
                vm.products = response.data;
            });
        };
    }
})();