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
$d4=$_POST[d4];
$d4_1=$_POST[d4_1];
$d4_1_1=$_POST[d4_1_1];
$d4_1_2=$_POST[d4_1_2];
$d4_2=$_POST[d4_2];
$d4_2_1=$_POST[d4_2_1];
$d4_2_2=$_POST[d4_2_2];
$d4_3=$_POST[d4_3];
$d4_3_1=$_POST[d4_3_1];
$d4_3_2=$_POST[d4_3_2];
$d4_4=$_POST[d4_4];
$d4_4_1=$_POST[d4_4_1];
$d4_4_2=$_POST[d4_4_2];
$d4_5=$_POST[d4_5];
$d4_5_1=$_POST[d4_5_1];
$d4_5_2=$_POST[d4_5_2];
$d4_6=$_POST[d4_6];
$d4_6_1=$_POST[d4_6_1];
$d4_6_2=$_POST[d4_6_2];
$d4_7=$_POST[d4_7];
$d4_7_1=$_POST[d4_7_1];
$d4_7_2=$_POST[d4_7_2];
$d4_8=$_POST[d4_8];
$d4_8_1=$_POST[d4_8_1];
$d4_8_2=$_POST[d4_8_2];
$d4_9=$_POST[d4_9];
$d4_9_1=$_POST[d4_9_1];
$d4_9_2=$_POST[d4_9_2];
$d4_10=$_POST[d4_10];
$d4_10_1=$_POST[d4_10_1];
$d4_10_2=$_POST[d4_10_2];
$d4_11=$_POST[d4_11];
$d4_11_1=$_POST[d4_11_1];
$d4_11_2=$_POST[d4_11_2];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$query="select HC from survey_d2 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_d2 (HC,survey_year,survey_no,d4,d4_1,d4_1_1,d4_1_2,d4_2,d4_2_1,d4_2_2,d4_3,d4_3_1,d4_3_2,d4_4,d4_4_1,d4_4_2,d4_5,d4_5_1,d4_5_2,d4_6,d4_6_1,d4_6_2,d4_7,d4_7_1,d4_7_2,d4_8,d4_8_1,d4_8_2,d4_9,d4_9_1,d4_9_2,d4_10,d4_10_1,d4_10_2,d4_11,d4_11_1,d4_11_2) values('$HC','$survey_year','$survey_no','$d4','$d4_1','$d4_1_1','$d4_1_2','$d4_2','$d4_2_1','$d4_2_2','$d4_3','$d4_3_1','$d4_3_2','$d4_4','$d4_4_1','$d4_4_2','$d4_5','$d4_5_1','$d4_5_2','$d4_6','$d4_6_1','$d4_6_2','$d4_7','$d4_7_1','$d4_7_2','$d4_8','$d4_8_1','$d4_8_2','$d4_9','$d4_9_1','$d4_9_2','$d4_10','$d4_10_1','$d4_10_2','$d4_11','$d4_11_1','$d4_11_2');";
$mysqli->query($query1);

$query1="update survey_d2 set d4='$d4',d4_1='$d4_1',d4_1_1='$d4_1_1',d4_1_2='$d4_1_2',d4_2='$d4_2',d4_2_1='$d4_2_1',d4_2_2='$d4_2_2',d4_3='$d4_3',d4_3_1='$d4_3_1',d4_3_2='$d4_3_2',d4_4='$d4_4',d4_4_1='$d4_4_1',d4_4_2='$d4_4_2',d4_5='$d4_5',d4_5_1='$d4_5_1',d4_5_2='$d4_5_2',d4_6='$d4_6',d4_6_1='$d4_6_1',d4_6_2='$d4_6_2',d4_7='$d4_7',d4_7_1='$d4_7_1',d4_7_2='$d4_7_2',d4_8='$d4_8',d4_8_1='$d4_8_1',d4_8_2='$d4_8_2',d4_9='$d4_9',d4_9_1='$d4_9_1',d4_9_2='$d4_9_2',d4_10='$d4_10',d4_10_1='$d4_10_1',d4_10_2='$d4_10_2',d4_11='$d4_11',d4_11_1='$d4_11_1',d4_11_2='$d4_11_2' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);

//echo$query1."<br>";
++
$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 4 2/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyd3'
</script>*/