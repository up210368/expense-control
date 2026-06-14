<h1>Template</h1>

---

<h2>Requirements</h2>
<p>The system display a monthly calendar</p>
<p>The system can change the calendar view between expected expenses and actual expenses</p>
<p>The calendar shows the total amount of daily spending</p>
<p>The system display a table of expenses categories</p>
<p>The calendar must highlight the current day</p>
<p>The system must allow for the recording of monthly and extraordinary income</p>
<p>The system must allow the recording of an expense acording to a date</p>
<p>The system must allow to record an expense with a description, payment method and amount</p>
<p>The mustem must calculate and show: total amount of monthly spending, total amount of monthly income, actual balance.</p>


<h1>Backend</h1>

---
<ul>
    <li>Database = <strong>SQLite</strong></li>
    <li>Language = <strong>C#</strong></li>
    <li>Architecture = <strong>Layer architecture</strong></li>
</ul>

---

<h1>Layer architecture</h1>
<p><strong>Infrastructure</strong> ref <strong>Domain</strong> ref <strong>Application</strong> ref <strong>API</strong></p>
<p>Infrastructure -> Persistence -> Migrations = SQLite DB</p>

