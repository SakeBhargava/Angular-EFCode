angular.module("artist")
    .factory("artistDataService", ['$http', '$q', function ($http, $q) {
        return {
            getArtists: function () {
                var def = $q.defer();

                $http.get('api/artist')
                    .then(function (response) {
                        def.resolve(response.data);
                    }, def.reject);

                return def.promise;
            },
            addArtist: function (artist) {
                var def = $q.defer();
                $http({
                    method: 'POST',
                    url: 'api/artist/add',
                    data: artist
                }).then(function (response) {
                    def.resolve(response.data);
                }, def.reject);

                return def.promise;;
            }
        }
}]);