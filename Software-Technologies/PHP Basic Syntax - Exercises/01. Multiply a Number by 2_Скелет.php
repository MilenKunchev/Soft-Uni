<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
    <br/>

    <?php
    if (isset($_GET['num'])){
        $num = $_GET['num'];
        $result = $num * 2;
        echo $result;
    }
    ?>
</form>
</body>
</html>