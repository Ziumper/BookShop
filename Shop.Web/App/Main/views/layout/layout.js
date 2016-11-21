(function () {
    var controllerId = 'app.views.layout';
    angular.module('app').controller(controllerId, [ '$rootScope',
        '$scope', function ($rootScope, $scope) {
            var vm = this;
            vm.count = 0;
            //Layout logic...
            $scope.searchContent = "";
            vm.myRegex = new RegExp(".{0,10}");

            //Get count products event change!
            $scope.$on('count', function(event, countProducts)
            {
                vm.count += countProducts;
            })

            vm.search = function()
            {
                if (vm.myRegex.test($scope.searchContent))
                {
                    $rootScope.$broadcast('search', $scope.searchContent);
                    $scope.searchContent = "";
                }
                
            }

        }]);
})();