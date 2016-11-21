(function () {
    angular.module('app').controller('app.views.books.createModal', [
        '$scope',
        '$uibModalInstance',
        'abp.services.app.coverService',
        'abp.services.app.carrierService',
        'abp.services.app.editionService',
        'abp.services.app.publishingHauseService',
        function ($scope, $uibModalInstance,coverService,carrierService,editionService,publishingHauseService) {
            var vm = this;

            vm.myRegeExp = '[1-9][0-9]{0,2}';
            vm.covers = [];
            vm.publishingHauses = [];
            vm.editions = [];
            vm.carriers = [];

            //Default
            $scope.countModel = 1;

          
            abp.ui.setBusy(null,
            coverService.getAllCovers({}).success(function (result) {
                vm.covers = result.items;
            }))

           
            abp.ui.setBusy(null,
            carrierService.getAllCarriers({}).success(function (result) {
                vm.carriers = result.items;
            }))

          
            abp.ui.setBusy(null,
            publishingHauseService.getAllPublishingHauses({}).success(function (result) {
               vm.publishingHauses = result.items;
            }))

         
            abp.ui.setBusy(null,
            editionService.getAllEditions({}).success(function (result) {
                vm.editions = result.items;
            }))

         
            vm.add = function (form)
            {
                if (form.$valid)
                {
                    $uibModalInstance.close($scope.countModel);
                }
            }

            vm.cancel = function ()
            {
                $uibModalInstance.dismiss();
            };

            
        }
    ]);
})();