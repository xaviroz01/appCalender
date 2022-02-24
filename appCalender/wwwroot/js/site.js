// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {
  var calendarEl = document.getElementById("calendar");

  var calendar = new FullCalendar.Calendar(calendarEl, {
    selectable: true,
    headerToolbar: {
      left: "prev,next today",
      center: "title",
      right: "dayGridMonth",
    },
    // select: function (info) {
    //   alert("วันที่เลือก " + info.startStr + " ถึง " + info.endStr);
    // },
    dateClick: function (info) {
      const modle = document.getElementById("exampleModal");
      modle.innerHTML;
      //   alert("Clicked on: " + info.startStr + info.endStr);
      // change the day's background color just for fun
      info.dayEl.style.backgroundColor = "red";
    },
  });

  calendar.render();
});
