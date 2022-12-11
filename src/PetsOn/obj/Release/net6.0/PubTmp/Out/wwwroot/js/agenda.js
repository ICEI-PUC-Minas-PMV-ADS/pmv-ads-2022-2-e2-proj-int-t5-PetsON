//var date = new Date()
//var d = date.getDate()
//m = date.getMonth()
//y = date.getFullYear()

// inicializa o Calendário

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        locale: 'pt-br',
        timeFormat: 'HH:mm',
        slotLabelFormat: 'HH:mm',
        allDayText: '24 horas',
        columnFormat: 'dddd',
        timeZone: 'UTC',
        themeSystem: 'bootstrap5',
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay,listMonth'
        },
        buttonText: {
            today: 'Hoje',
            month: 'Mês',
            week: 'Semana',
            day: 'Dia'
        },
        weekNumbers: true,
        dayMaxEvents: true, // allow "more" link when too many events
        events: 'https://fullcalendar.io/api/demo-feeds/events.json'

    });

    calendar.render();
});

