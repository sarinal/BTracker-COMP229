/*  Author: Sarina Luu, Sam Buensuceso
    Student#: 300838958, 300799984
    Date: October 6, 2016
    Version: 1.0
    File Name: app.js*/

jQuery.fn.redraw = function () {
    return this.hide(0, function () { jQuery(this).show() });
};
jQuery(document).ready(function () {
    jQuery('body').redraw();
});