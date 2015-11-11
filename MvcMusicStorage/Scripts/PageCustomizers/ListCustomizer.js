$(function () {
    function loadAllAlbums() {
        $.get('MusicCollection/Albums/', function (data) {
            $('[data-container="album-view"]').html(data);
        });
    };

    function clickCallback($row) {
        var artistId = $row.children('div [artist-id]').attr('artist-id');
        $.get('MusicCollection/ArtistAlbums/' + artistId, function (data) {
            $('[data-container="album-view"]').html(data);
        });
    };

    $('.list-group .list-group-item').click(function () {
        if (!$(this).hasClass('active')) {
            $('.list-group .list-group-item').removeClass('active');
            $(this).addClass('active');

            clickCallback($(this));
        }
    });

    loadAllAlbums();
});