/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
//exit();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$HC=$_SESSION["HC"];
$b11_1=$_POST[b11_1];
$b11_1_1=$_POST[b11_1_1];
$b11_2=$_POST[b11_2];
$b11_2_1=$_POST[b11_2_1];
$b12_1=$_POST[b12_1];
$b12_2=$_POST[b12_2];
$b12_3=$_POST[b12_3];
$b12_4=$_POST[b12_4];
$b12_5=$_POST[b12_5];
$b12_6=$_POST[b12_6];
$b12_7=$_POST[b12_7];
$b12_8=$_POST[b12_8];
$b12_9=$_POST[b12_9];
$b12_10=$_POST[b12_10];
$b12_11=$_POST[b12_11];
$b12_12=$_POST[b12_12];
$b12_12_1=$_POST[b12_12_1];
$b13_1=$_POST[b13_1];
$b13_2=$_POST[b13_2];
$b13_3=$_POST[b13_3];
$b13_4=$_POST[b13_4];
$b13_5=$_POST[b13_5];
$b13_6=$_POST[b13_6];
$b13_7=$_POST[b13_7];
$b13_8=$_POST[b13_8];
$b13_9=$_POST[b13_9];
$b13_10=$_POST[b13_10];
$b13_11=$_POST[b13_11];
$b13_12=$_POST[b13_12];
$b13_12_1=$_POST[b13_12_1];
$b14=$_POST[b14];
$b15=$_POST[b15];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}


$query="select HC from survey_b3 where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_b3 (HC,survey_year,survey_no,b11_1,b11_1_1,b11_2,b11_2_1,b12_1,b12_2,b12_3,b12_4,b12_5,b12_6,b12_7,b12_8,b12_9,b12_10,b12_11,b12_12,b12_12_1,b13_1,b13_2,b13_3,b13_4,b13_5,b13_6,b13_7,b13_8,b13_9,b13_10,b13_11,b13_12,b14,b15,b13_12_1) values('$HC','$survey_year','$survey_no','$b11_1','$b11_1_1','$b11_2','$b11_2_1','$b12_1','$b12_2','$b12_3','$b12_4','$b12_5','$b12_6','$b12_7','$b12_8','$b12_9','$b12_10','$b12_11','$b12_12','$b12_12_1','$b13_1','$b13_2','$b13_3','$b13_4','$b13_5','$b13_6','$b13_7','$b13_8','$b13_9','$b13_10','$b13_11','$b13_12','$b14','$b15','$b13_12_1');";
$mysqli->query($query1);

$query1="update survey_b3 set b11_1='$b11_1',b11_1_1='$b11_1_1',b11_2='$b11_2',b11_2_1='$b11_2_1',b12_1='$b12_1',b12_2='$b12_2',b12_3='$b12_3',b12_4='$b12_4',b12_5='$b12_5',b12_6='$b12_6',b12_7='$b12_7',b12_8='$b12_8',b12_9='$b12_9',b12_10='$b12_10',b12_11='$b12_11',b12_12='$b12_12',b12_12_1='$b12_12_1',b13_1='$b13_1',b13_2='$b13_2',b13_3='$b13_3',b13_4='$b13_4',b13_5='$b13_5',b13_6='$b13_6',b13_7='$b13_7',b13_8='$b13_8',b13_9='$b13_9',b13_10='$b13_10',b13_11='$b13_11',b13_12='$b13_12',b14='$b14',b15='$b15',b13_12_1='$b13_12_1' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);

//echo$query1."<br>";


$query_up1="update survey_staff set ch2_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 2 4/4')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyc1'
</script>*/
