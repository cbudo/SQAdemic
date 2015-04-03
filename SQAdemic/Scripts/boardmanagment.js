var drawCards = function () {
    console.log('hit');
    $.get('Home/playerDraw', function (data) {
        $('#testplayerreturn').text = data;
    });
    $('#button1').hide;
}
