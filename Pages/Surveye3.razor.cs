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
$e3=$_POST[e3];
$e4=$_POST[e4];
$e5=$_POST[e5];
$e6=$_POST[e6];
$e7_1=$_POST[e7_1];
$e7_2=$_POST[e7_2];
$e7_3=$_POST[e7_3];
$e7_4=$_POST[e7_4];
$e7_5=$_POST[e7_5];
$e7_6=$_POST[e7_6];
$e7_7=$_POST[e7_7];
$e7_8=$_POST[e7_8];
$e7_9=$_POST[e7_9];
$e7_10=$_POST[e7_10];
$e7_11=$_POST[e7_11];
$e7_11_1=$_POST[e7_11_1];
$e8=$_POST[e8];
$e8_1_1=$_POST[e8_1_1];
$e8_1_2=$_POST[e8_1_2];
$e8_1_3=$_POST[e8_1_3];
$e8_1_4=$_POST[e8_1_4];
$e8_1_4_1=$_POST[e8_1_4_1];
$e8_2_1=$_POST[e8_2_1];
$e8_2_2=$_POST[e8_2_2];
$e8_2_3=$_POST[e8_2_3];
$e8_2_4=$_POST[e8_2_4];
$e8_2_5=$_POST[e8_2_5];
$e8_2_6=$_POST[e8_2_6];
$e8_2_7=$_POST[e8_2_7];
$e8_2_8=$_POST[e8_2_8];
$e8_2_9=$_POST[e8_2_9];
$e8_2_10=$_POST[e8_2_10];
$e8_2_11=$_POST[e8_2_11];
$e8_2_11_1=$_POST[e8_2_11_1];
$e9_1=$_POST[e9_1];
$e9_2=$_POST[e9_2];
$e9_3=$_POST[e9_3];
$e9_4=$_POST[e9_4];
$e10_1=$_POST[e10_1];
$e10_2=$_POST[e10_2];
$e10_3=$_POST[e10_3];
$e10_4=$_POST[e10_4];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$query="select HC from survey_e3 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();
if($row->HC){//if($row->HC){
	$query1="update survey_e3 set e3='$e3',e4='$e4',e5='$e5',e6='$e6',e7_1='$e7_1',e7_2='$e7_2',e7_3='$e7_3',e7_4='$e7_4',e7_5='$e7_5',e7_6='$e7_6',e7_7='$e7_7',e7_8='$e7_8',e7_9='$e7_9',e7_10='$e7_10',e7_11='$e7_11',e7_11_1='$e7_11_1',e8='$e8',e8_1_1='$e8_1_1',e8_1_2='$e8_1_2',e8_1_3='$e8_1_3',e8_1_4='$e8_1_4',e8_1_4_1='$e8_1_4_1',e8_2_1='$e8_2_1',e8_2_2='$e8_2_2',e8_2_3='$e8_2_3',e8_2_4='$e8_2_4',e8_2_5='$e8_2_5',e8_2_6='$e8_2_6',e8_2_7='$e8_2_7',e8_2_8='$e8_2_8',e8_2_9='$e8_2_9',e8_2_10='$e8_2_10',e8_2_11='$e8_2_11',e8_2_11_1='$e8_2_11_1',e9_1='$e9_1',e9_2='$e9_2',e9_3='$e9_3',e9_4='$e9_4',e10_1='$e10_1',e10_2='$e10_2',e10_3='$e10_3',e10_4='$e10_4' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
}else{//if($row->HC){
	$query1="insert into survey_e3 (HC,survey_year,survey_no,e3,e4,e5,e6,e7_1,e7_2,e7_3,e7_4,e7_5,e7_6,e7_7,e7_8,e7_9,e7_10,e7_11,e7_11_1,e8,e8_1_1,e8_1_2,e8_1_3,e8_1_4,e8_1_4_1,e8_2_1,e8_2_2,e8_2_3,e8_2_4,e8_2_5,e8_2_6,e8_2_7,e8_2_8,e8_2_9,e8_2_10,e8_2_11,e8_2_11_1,e9_1,e9_2,e9_3,e9_4,e10_1,e10_2,e10_3,e10_4) values('$HC','$survey_year','$survey_no','$e3','$e4','$e5','$e6','$e7_1','$e7_2','$e7_3','$e7_4','$e7_5','$e7_6','$e7_7','$e7_8','$e7_9','$e7_10','$e7_11','$e7_11_1','$e8','$e8_1_1','$e8_1_2','$e8_1_3','$e8_1_4','$e8_1_4_1','$e8_2_1','$e8_2_2','$e8_2_3','$e8_2_4','$e8_2_5','$e8_2_6','$e8_2_7','$e8_2_8','$e8_2_9','$e8_2_10','$e8_2_11','$e8_2_11_1','$e9_1','$e9_2','$e9_3','$e9_4','$e10_1','$e10_2','$e10_3','$e10_4');";
}//if($row->HC){

//echo$query1."<br>";
$mysqli->query($query1);

$query_up1="update survey_staff set ch5_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 5 3/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyf'
</script>*/