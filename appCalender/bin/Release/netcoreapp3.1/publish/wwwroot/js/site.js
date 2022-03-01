// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {
  var calendarEl = document.getElementById("calendar");

  var calendar = new FullCalendar.Calendar(calendarEl, {
    selectable: true,
    headerToolbar: {
      left: "prev",
      center: "title",
      right: "today,next",
    },
    // select: function (info) {
    //   alert("วันที่เลือก " + info.startStr + " ถึง " + info.endStr);
    // },
    dateClick: function (info) {
      //alert("สิ่งที่ต้องทำ" + info.startStr + info.endStr);
      //   prompt("day end", "ddd");
      //   prompt("time start", "ddd");
      //   prompt("time end", "ddd");
      const modal = document.getElementById("myModal");
      modal.style.display = "block";
      const span = document.getElementsByClassName("close")[0];
      span.onclick = function () {
        modal.style.display = "none";
      };

      // change the day's background color just for fun
      info.dayEl.style.backgroundColor = "red";
    },
  });

  calendar.render();
});

async function main() {
  await liff.init({ liffId: "1656934937-3eq8pqWw" });
  if (liff.isLoggedIn()) {
    getProfileLine();
  } else {
    liff.login();
  }
}
main();
async function getProfileLine() {
  const profile = await liff.getProfile();
  document.getElementById("name").append(profile.displayName);
}
