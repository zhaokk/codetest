<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        if ($_SERVER["REQUEST_METHOD"] == "GET") {
            echo <<<output
            <form method="post">
            <h1>code test</h1>
            <p>task3 example format:1 2 3 4 5 6 7 8</p>
            <select name="task">
                <option value="1">task1 reverse</option>
                <option value="2">task2 shuffle</option>
                <option value="3">task3 find median</option>
            </select>
            <label for="other">  Data to process</label>
            <input name="input">
            <input type="submit">
            </form>
output;
        }else if($_SERVER["REQUEST_METHOD"] == "POST"){
            $inputString = $_POST["input"];
            $taskId =$_POST["task"] ;
            //echo $inputString;
            echo "<h1>task: ";
            echo $taskId;
            echo "</h1>";
            echo "<h1> result:";
            if($taskId=="1"){
                //reverse
                echo strrev($inputString);
            }else if($taskId=="2"){
                echo str_shuffle($inputString);
            }else if($taskId =="3"){
                $numbers = explode(" ", $inputString);
                asort($numbers);
                $newArray = array();
                $index = 0;
                foreach ($numbers as $value) {
                    $newArray[$index]=$value;
                    $index++;
                }
                $amount = count($newArray);
                
                    if($amount%2==0){
                        echo $newArray[$amount/2];
                        echo " and ";
                        echo $newArray[$amount/2-1];
                    }else{
                        echo $newArray[$amount/2];
                    }
                
            }
            echo "</h1>";
        }
        ?>
    </body>
</html>
