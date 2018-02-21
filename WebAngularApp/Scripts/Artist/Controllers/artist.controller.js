angular.module("artist")
    .controller("artistController", ['$scope', 'artistDataService', 'ngDialog',
        function (scope, artistDataService, ngDialog) {
            var self = this;
            self.artists = [];
            artistDataService.getArtists().then(function (data) {
                self.artists = data;
            });
            self.createNewDialogOpen = function () {
                var dialog = ngDialog.open({
                    template: '/Scripts/Artist/Controllers/CreateArtist.html',
                    className: 'ngdialog-theme-default',
                    plain: false,
                    showClose: true,
                    closeByDocument: true,
                    closeByEscape: true,
                    appendTo: false,
                    controller: ['$scope', function ($scope) {
                        $scope.addNewItem = function () {
                            var artist = {
                                Name: $scope.name,
                                DateOfBirth: $scope.dateOfBirth,
                                LivingPlace: $scope.livingPlace,
                                Contact: $scope.contact,
                                Movies: $scope.movies
                            };

                            dialog.close(artist);
                        }
                    }]
                });

                dialog.closePromise.then(function (artist) {
                    artistDataService.addArtist(artist.value).then(function () {
                        self.artists.push(artist.value);
                    });
                    
                });
            };

            

           
}]);