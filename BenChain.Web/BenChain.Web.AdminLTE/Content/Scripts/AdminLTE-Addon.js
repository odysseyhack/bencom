// status change when accordion change
$('.panel-title').bind('click', function () {

  var panel_title = $(this);
  var status_toggle = panel_title.find('.status-toggle');
  if (typeof panel_title.data('toggle') !== 'undefined') {
    status_toggle.html(adminLteChangeHtml(panel_title));
  }

  var box_body = panel_title.closest('.box-body');
  box_body.on('show.bs.collapse', '.collapse', function () {
    adminLteCollapseBox(box_body);
  });

});

function adminLteChangeHtml(panel_title) {
  if (panel_title.hasClass('collapsed')) {
    return 'Collapse <i class="zmdi zmdi-chevron-up"></i>';
  } else {
    return adminLteOriginalTitle();
  }
}

function adminLteCollapseBox(box_body) {
  box_body.find('.collapse.in').each(function () {
    var box = $(this);
    box.collapse('hide');
    box.parent().find('.status-toggle').html(adminLteOriginalTitle());
  });
}

function adminLteOriginalTitle() {
  return 'Review <i class="zmdi zmdi-chevron-down"></i>';
}