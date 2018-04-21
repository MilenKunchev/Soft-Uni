<html>

<head>
<meta http-equiv=Content-Type content="text/html; charset=windows-1251">
<meta name=Generator content="Microsoft Word 14 (filtered)">


</head>

<body lang=EN-US link=blue vlink=purple>

<div class=WordSection1>

<h1 align=center style='margin-top:0cm;text-align:center'>Practical Exam –
Shopping List</h1>

<p class=MsoNormal>You have been tasked to create a simple application that
simulates a Shopping List. The application should hold <b>products</b>, which
are the main app <b>entities</b>. The app is called <span class=CodeChar>ShoppingList</span>.</p>

<p class=MsoNormal>The functionality of the application should support <b>creating</b>,
<b>listing</b>, <b>editing</b> products.</p>

<p class=MsoNormal>The application should <b>persist</b> the data into a <b>database</b>.</p>

<h2>Overview</h2>

<p class=MsoNormal>Your application should be built on <b>each one </b>of the <b>following
technologies</b>:</p>

<h3>PHP</h3>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Symfony </b>framework</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Twig </b>view engine</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Doctrine</b> ORM</p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>MySQL </b>database</p>

<h3>JavaScript</h3>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>NodeJS </b>+<b> ExpressJS </b>frameworks</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Handlebars.js </b>view engine</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Sequelize ORM</b></p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>MySQL </b>database</p>

<h3>Java</h3>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Spring </b>framework (<b>Spring MVC</b> + <b>Spring Boot</b> +
<b>Spring Data</b>)</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Thymeleaf </b>view engine</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>JPA </b>/ <b>Hibernate ORM </b>+<b> Spring Data </b>data
access</p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>MySQL </b>database</p>

<h3>C#</h3>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>ASP.NET </b>framework (<b>ASP.NET MVC</b> + <b>Entity
Framework Core</b>)</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Razor </b>view engine</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Entity Framework Core </b>ORM</p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>MySQL </b>database</p>

<h2>Data Model</h2>

<p class=MsoNormal>The <span class=CodeChar>Product</span> entity holds <b>5
properties</b>:</p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'><span
class=CodeChar><span style='font-family:Symbol;font-weight:normal'>·<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span class=CodeChar>id</span><span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'> –</span></span><span
class=CodeChar><span style='font-family:"Calibri","sans-serif";font-weight:
normal'> </span></span><span class=CodeChar><span style='font-family:"Calibri","sans-serif";
font-weight:normal'>technology-dependent identifier </span></span><span
class=CodeChar><span style='font-family:"Calibri","sans-serif";font-weight:
normal'>(</span>ObjectID</span><span class=CodeChar><span style='font-family:
"Calibri","sans-serif";font-weight:normal'> for JavaScript, </span>int</span><span
class=CodeChar><span style='font-family:"Calibri","sans-serif";font-weight:
normal'> for all other technologies)</span></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
class=CodeChar><span style='font-family:Symbol;font-weight:normal'>·<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span class=CodeChar>priority</span> <span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>– non-null
integer</span></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span class=CodeChar>name</span><span class=CodeChar><span
style='font-family:"Calibri","sans-serif"'> </span></span><span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>– non-empty text</span></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
class=CodeChar><span style='font-family:Symbol;font-weight:normal'>·<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span class=CodeChar>quantity</span> <span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>– non-null
integer</span></span></p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span class=CodeChar>status</span> <span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>– non-empty text
(will either be “</span>bought</span><span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>” or “</span>not
bought</span><span class=CodeChar><span style='font-family:"Calibri","sans-serif";
font-weight:normal'>”).</span></span></p>

<h2>Project Skeletons</h2>

<p class=MsoNormal><a name="_Hlk490473892">You will be given the applications’ </a><span
class=CodeChar>skeletons</span>, which holds about <b>90%</b> of the logic.
You’ll be given some <b>files</b> (<b>controllers</b>, <b>models</b> etc.). The
files will have<b> partially implemented logic</b>, so you’ll need to write
some code for the application to <b>function properly</b>.</p>

<p class=MsoNormal>The application’s views will be given to you fully
implemented. You only need to include them in your business logic.</p>

<p class=MsoNormal><b>Each technology</b> will have its <b>own skeleton</b>,
and the <b>different</b> <b>skeletons</b> may <b>differ</b> in <b>terms</b> of <b>what
is given to you</b> and <b>what is to be implemented</b>.</p>

<p class=MsoNormal>Everything that has been given to you inside the skeleton is
<b>correctly implemented </b>and if you write your code <b>correctly</b>, the
application should work just fine. You are free to change anything in the
Skeleton on your account.</p>

<h2>User Interface</h2>

<p class=MsoNormal>This is the user interface or how the application’s pages
should look in their final form (fully implemented). You have several pages,
described below:</p>

<h3>Index Page</h3>

<h4>Route: <span class=CodeChar><span style='color:windowtext'>“/”</span></span></h4>

<p class=MsoNormal>Displays <b>all</b> the <b>products</b> from the database with<b>
an option </b>to <b>modify</b> them.</p>

<p class=MsoNormal align=center style='text-align:center'><img width=552
height=316 id="Picture 11" src="readme.md_files/image001.jpg"></p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal>&nbsp;</p>

<h3>Create Page</h3>

<h4>Route: <span class=CodeChar><span style='color:windowtext'>“/create”</span></span></h4>

<p class=MsoNormal><img width=257 height=314 id="Picture 5"
src="readme.md_files/image002.jpg"></p>

<h3>Edit Page</h3>

<h4>Route: <span class=CodeChar><span style='color:windowtext'>“/edit/{id}”</span></span></h4>

<p class=MsoNormal><img width=257 height=362 id="Picture 8"
src="readme.md_files/image003.jpg">          <img width=241 height=362
id="Picture 10" src="readme.md_files/image004.jpg"></p>

<p class=MsoNormal>&nbsp;</p>

<h2>Problem</h2>

<p class=MsoNormal>As you can see the different pages are on different routes.
Most of the routing logic will be given to you in the <b>Skeleton</b>, but you
should make sure that the application <b>works properly</b>.</p>

<p class=MsoNormal>Implement the “<b>ShoppingList” app</b> using all the above
described <b>4 technologies</b>.</p>

<p class=MsoNormal>&nbsp;</p>

</div>

</body>

</html>
