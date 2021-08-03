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
$d5=$_POST[d5];
$d5_1=$_POST[d5_1];
$d5_1_1=$_POST[d5_1_1];
$d5_1_2=$_POST[d5_1_2];
$d5_2=$_POST[d5_2];
$d5_2_1=$_POST[d5_2_1];
$d5_2_2=$_POST[d5_2_2];
$d5_3=$_POST[d5_3];
$d5_3_1=$_POST[d5_3_1];
$d5_3_2=$_POST[d5_3_2];
$d5_4=$_POST[d5_4];
$d5_4_1=$_POST[d5_4_1];
$d5_4_2=$_POST[d5_4_2];
$d5_5=$_POST[d5_5];
$d5_5_1=$_POST[d5_5_1];
$d5_5_2=$_POST[d5_5_2];
$d5_6=$_POST[d5_6];
$d5_6_1=$_POST[d5_6_1];
$d5_6_2=$_POST[d5_6_2];
$d5_7=$_POST[d5_7];
$d5_7_1=$_POST[d5_7_1];
$d5_7_2=$_POST[d5_7_2];
$d5_8=$_POST[d5_8];
$d5_8_1=$_POST[d5_8_1];
$d5_8_2=$_POST[d5_8_2];
$d5_9=$_POST[d5_9];
$d5_9_1=$_POST[d5_9_1];
$d5_9_2=$_POST[d5_9_2];
$d5_10=$_POST[d5_10];
$d5_10_1=$_POST[d5_10_1];
$d5_10_2=$_POST[d5_10_2];
$d5_11=$_POST[d5_11];
$d5_11_1=$_POST[d5_11_1];
$d5_11_2=$_POST[d5_11_2];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$query1="insert into survey_d3 (HC,survey_year,survey_no,d5,d5_1,d5_1_1,d5_1_2,d5_2,d5_2_1,d5_2_2,d5_3,d5_3_1,d5_3_2,d5_4,d5_4_1,d5_4_2,d5_5,d5_5_1,d5_5_2,d5_6,d5_6_1,d5_6_2,d5_7,d5_7_1,d5_7_2,d5_8,d5_8_1,d5_8_2,d5_9,d5_9_1,d5_9_2,d5_10,d5_10_1,d5_10_2,d5_11,d5_11_1,d5_11_2) values('$HC','$survey_year','$survey_no','$d5','$d5_1','$d5_1_1','$d5_1_2','$d5_2','$d5_2_1','$d5_2_2','$d5_3','$d5_3_1','$d5_3_2','$d5_4','$d5_4_1','$d5_4_2','$d5_5','$d5_5_1','$d5_5_2','$d5_6','$d5_6_1','$d5_6_2','$d5_7','$d5_7_1','$d5_7_2','$d5_8','$d5_8_1','$d5_8_2','$d5_9','$d5_9_1','$d5_9_2','$d5_10','$d5_10_1','$d5_10_2','$d5_11','$d5_11_1','$d5_11_2');";
$mysqli->query($query1);

$query1="update survey_d3 set d5='$d5',d5_1='$d5_1',d5_1_1='$d5_1_1',d5_1_2='$d5_1_2',d5_2='$d5_2',d5_2_1='$d5_2_1',d5_2_2='$d5_2_2',d5_3='$d5_3',d5_3_1='$d5_3_1',d5_3_2='$d5_3_2',d5_4='$d5_4',d5_4_1='$d5_4_1',d5_4_2='$d5_4_2',d5_5='$d5_5',d5_5_1='$d5_5_1',d5_5_2='$d5_5_2',d5_6='$d5_6',d5_6_1='$d5_6_1',d5_6_2='$d5_6_2',d5_7='$d5_7',d5_7_1='$d5_7_1',d5_7_2='$d5_7_2',d5_8='$d5_8',d5_8_1='$d5_8_1',d5_8_2='$d5_8_2',d5_9='$d5_9',d5_9_1='$d5_9_1',d5_9_2='$d5_9_2',d5_10='$d5_10',d5_10_1='$d5_10_1',d5_10_2='$d5_10_2',d5_11='$d5_11',d5_11_1='$d5_11_1',d5_11_2='$d5_11_2' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);

//echo$query1."<br>";


$query_up1="update survey_staff set ch4_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 4 3/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveye1'
</script>*/