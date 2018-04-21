<html>

<head>
<meta http-equiv=Content-Type content="text/html; charset=windows-1251">
<meta name=Generator content="Microsoft Word 14 (filtered)">


</head>

<body lang=EN-US link=blue vlink=purple>

<div class=WordSection1>

<h1 align=center style='margin-top:0cm;text-align:center'>Practical Exam – Project
Rider</h1>

<p class=MsoNormal>You have been tasked to create a simple application for a
Startup-Helping Company. The application should hold <b>projects</b>, which are
the main app <b>entities</b>. The app is called <span class=CodeChar>ProjectRider</span>.</p>

<p class=MsoNormal>The functionality of the application should support <b>creating</b>,
<b>listing, editing</b>, <b>deleting</b> projects.</p>

<p class=MsoNormal>The application should <b>persist</b> the data into a MySQL <b>database</b>.</p>

<h2>Overview</h2>

<p class=MsoNormal>Your application should be built on <b>each one </b>of the <b>following
technologies</b>:</p>

<h3>JavaScript</h3>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>NodeJS </b>+<b> ExpressJS </b>frameworks</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Handlebars.js </b>view engine</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>Sequelize </b>ORM</p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><b>MySQL </b>database</p>

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
</span></span><b>ASP.NET Core </b>framework (<b>ASP.NET MVC</b> + <b>Entity
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

<p class=MsoNormal>The <span class=CodeChar>Project</span> entity holds <b>4
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
</span></span></span><span class=CodeChar>title</span> <span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>– non-empty text</span></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span class=CodeChar>description</span><span class=CodeChar><span
style='font-family:"Calibri","sans-serif"'> </span></span><span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>– non-empty text</span></span></p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'><span
style='font-family:Symbol'>·<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span class=CodeChar>budget</span> <span class=CodeChar><span
style='font-family:"Calibri","sans-serif";font-weight:normal'>– a 32-bit
integer</span></span></p>

<h2>Project Skeletons</h2>

<p class=MsoNormal><a name="_Hlk490473892">You will be given the applications’ </a><span
class=CodeChar>skeletons</span>, which holds about <b>90%</b> of the logic.
You’ll be given some <b>files</b> (<b>controllers</b>, <b>models</b> etc.). The
files will have<b> partially implemented logic</b>, so you’ll need to write
some code for the application to <b>function properly</b>.</p>

<p class=MsoNormal>The application’s views will be given to you fully implemented.
You only need to include them in your business logic.</p>

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

<p class=MsoNormal>Displays <b>all</b> the <b>projects</b> from the database with<b>
options </b>to <b>edit </b>or <b>delete</b> them.</p>

<p class=MsoNormal align=center style='text-align:center'><img width=695
height=199 id="Picture 5" src="readme.md_files/image001.jpg"></p>

<h3>Create Page</h3>

<h4>Route: <span class=CodeChar><span style='color:windowtext'>“/create”</span></span></h4>

<p class=MsoNormal align=center style='text-align:center'><img width=539
height=417 id="Picture 10" src="readme.md_files/image002.jpg"></p>

<h3>Edit Page</h3>

<h4>Route: <span class=CodeChar><span style='color:windowtext'>“/edit/{id}”</span></span></h4>

<p class=MsoNormal align=center style='text-align:center'><img width=536
height=415 id="Picture 11" src="readme.md_files/image003.jpg"></p>

<h3>Delete Page</h3>

<h4>Route: <span class=CodeChar><span style='color:windowtext'>“/delete/{id}”</span></span></h4>

<p class=MsoNormal align=center style='text-align:center'><img width=527
height=403 id="Picture 13" src="readme.md_files/image004.jpg"></p>

<h2>Problem</h2>

<p class=MsoNormal>As you can see the different pages are on different routes.
Most of the routing logic will be given to you in the <b>Skeleton</b>, but you
should make sure that the application <b>works properly</b>.</p>

<p class=MsoNormal>Implement the “<b>ProjectRider” app</b> using all the above
described <b>4 technologies</b>.</p>

<h2>Setup</h2>

<p class=MsoNormal>Before you start working, make sure you <b>download all the
dependencies</b> (packages) required for each technology and <b>set up</b> the <b>databases</b>!
Below are instructions on how to do this:</p>

<h3>PHP and Symfony</h3>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'>1.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Go
into the <b>root directory</b> of the project (where the <span class=CodeChar>bin</span>
folder resides)</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'>2.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Make
sure you’ve started your <b>MySQL server</b> (either from <b>XAMPP</b> or
standalone)</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'>3.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Open
a <b>shell</b> / <b>command prompt</b> /<b> PowerShell</b> window in the <b>root
directory</b>: [Shift] + [Right click] <span style='font-family:Wingdings'>&egrave;</span>
[Open command window here]</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'>4.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Enter
the “<span class=CodeChar>php composer.phar install</span>” command to restore
its <b>Composer dependencies</b> (described in <span class=CodeChar>composer.json</span>)</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'>5.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Enter
the “<span class=CodeChar>php bin/console doctrine:database:create
--if-not-exists</span>” command</p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'>6.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Done!</p>

<h3>JavaScript and Node.js</h3>

<p class=MsoListParagraphCxSpFirst style='text-indent:-18.0pt'>1.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Go
into the <b>root directory</b> of the project (where the <span class=CodeChar>bin</span>
folder resides)</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'>2.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Open
a <b>shell</b> / <b>command prompt</b> /<b> PowerShell</b> window in the <b>root
directory</b>: [Shift] + [Right click] <span style='font-family:Wingdings'>&egrave;</span>
[Open command window here]</p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-18.0pt'>3.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Enter
the “<span class=CodeChar>npm install</span>” command to restore its <b>Node.js
dependencies</b> (described in <span class=CodeChar>package.json</span>)</p>

<p class=MsoListParagraphCxSpLast style='text-indent:-18.0pt'>4.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Done!</p>

<h3>C# and ASP.NET</h3>

<p class=MsoNormal>The C# project will automatically resolve its <b>NuGet
dependencies</b> (described in <span class=CodeChar>packages.config</span>)
using the NuGet package restore when the project is built.</p>

<h3>Java and Spring MVC</h3>

<p class=MsoNormal>The Java project will automatically resolve its <b>Maven
dependencies</b> (described in <span class=CodeChar>pom.xml</span>) when the
project is built.</p>

</div>

</body>

</html>
