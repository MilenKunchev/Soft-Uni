<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num"/>
    <input type="submit"/>
</form>
<?php
if (isset($_GET['num'])) {

    $num = intval($_GET['num']);
    $f1 = 1;
    $f2 = 1;
    $nFib = $f1 + $f2;

    echo $f1 . " ";
    echo $f2 . " ";
    echo $nFib . " ";

    for ($i = 3; $i < $num; $i++) {

        $f1 = $f2;
        $f2 = $nFib;
        $nFib = $f1 + $f2;

        echo $nFib . " ";

    }
}
?>
</body>
</html>