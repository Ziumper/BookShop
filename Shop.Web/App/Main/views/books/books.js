(function () {
    var app = angular.module('app');
    var controllerId = 'app.views.books';
    app.controller(controllerId, [
        '$rootScope',
        '$scope', '$uibModal',
        'abp.services.app.bookService',
        function
            ($rootScope, $scope, $uibModal, bookService)
        {
            var bm = this;
            bm.books = [];

            bm.content = 0;
       

            bm.getBooksPreview = function(amount)
            {
                bm.content = 4;
                abp.ui.setBusy(null,
            bookService.getPreviewBooks({
                amountOfDays : amount
            }).success(function (result) {
                bm.books = result.items;
            }))
            }

            bm.getBooksNew = function(amount)
            {
                bm.content = 3;
                abp.ui.setBusy(null,
            bookService.getNewBooks({
                amountOfDays: amount
            }).success(function (result) {
                bm.books = result.items;
            }))
            }

            bm.getBooksSpecial = function ()
            {
                bm.content = 5;
                abp.ui.setBusy(null,
             bookService.getSpecialOccasion({}).success(function (result) {
                      bm.books = result.items;
                  }))
            }

           

            bm.getBooksType = function(typeOfBook)
            {
                bm.content = typeOfBook;
               
                abp.ui.setBusy(null,
                bookService.getBooksByType(
                    {
                        type : typeOfBook
                    }
                    ).success(function (result) {
                    bm.books = result.items;
                }))

               
            }

            bm.refreshBooks = function ()
            {
                bm.content = 0;
              
                abp.ui.setBusy(null,
                bookService.getAllBooks({}).success(function (result) {
                    bm.books = result.items;
                }))

            }
            
            function addToCart(amount) {
                $rootScope.$broadcast('count', amount);
            }

            $scope.$on('search', function (event, searchContent) {
                abp.ui.setBusy(null,
                 bookService.searchForBooks({
                     contentId: bm.content,
                     searchText: searchContent
                 }).success(function (result) {
                     if (result.items.length == 0)
                     {
                         alert("W bazie danych nie odnaleziono produktów spełniających dane kryteria szukania");
                     }
                     else bm.books = result.items;
                     
                 }))
            })


            bm.addToShoppingCart = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/books/createModal.cshtml',
                    controller: 'app.views.books.createModal as vm',
                    backdrop: 'static',
                    
                });

                modalInstance.result.then(function (result) {
                    //add 
                    addToCart(parseInt(result));
                });
            };
           

            bm.refreshBooks();
            
            
        }
    ]);
})();