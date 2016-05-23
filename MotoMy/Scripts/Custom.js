String.prototype.capitalizeFirstLetter = function () {
    return this.charAt(0).toUpperCase() + this.slice(1);
}
function activateMenu(parent, child) {
    var _this = $('nav > ul > li[data-menu="' + parent + '"]');
    if (_this.has('ul > li[data-menu="' + child + '"]').length){
        _this.children('a[title="' + parent.capitalizeFirstLetter() + '"]')
            .trigger('click');
        _this.children('ul').children('li[data-menu="' + child + '"]').addClass('active');
    } else {
        _this.addClass('active');
    }        
}
function smallBoxAlert(t, msg, type, timeout) {
    type = type || 'success';
    timeout = timeout || 8000;
    var opt = {
        title: t,
        content: msg,
        color: '"#739E73"',
        timeout: timeout,
        icon: "fa fa-check"
    };
    switch (type) {
        case 'info':
            opt.color = '#5384AF';
            opt.icon = 'fa fa-bell swing animated';
            break;
        case 'error':
            opt.color = '#C46A69';
            opt.icon = 'fa fa-warning shake animated';
            break;
        default:
            break;
    }
    $.smallBox(opt);
}