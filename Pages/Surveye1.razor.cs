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
$e1_1_1=$_POST[e1_1_1];
$e1_1_2=$_POST[e1_1_2];
$e1_1_3=$_POST[e1_1_3];
$e1_2_1=$_POST[e1_2_1];
$e1_2_2=$_POST[e1_2_2];
$e1_2_3=$_POST[e1_2_3];
$e1_3_1=$_POST[e1_3_1];
$e1_3_2=$_POST[e1_3_2];
$e1_3_3=$_POST[e1_3_3];
$e1_4_1=$_POST[e1_4_1];
$e1_4_2=$_POST[e1_4_2];
$e1_4_3=$_POST[e1_4_3];
$e1_5_1=$_POST[e1_5_1];
$e1_5_2=$_POST[e1_5_2];
$e1_5_3=$_POST[e1_5_3];
$e1_6_4=$_POST[e1_6_4];
$e1_6_1=$_POST[e1_6_1];
$e1_6_2=$_POST[e1_6_2];
$e1_6_3=$_POST[e1_6_3];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$query1="insert into survey_e1 (HC,survey_year,survey_no,e1_1_1,e1_1_2,e1_1_3,e1_2_1,e1_2_2,e1_2_3,e1_3_1,e1_3_2,e1_3_3,e1_4_1,e1_4_2,e1_4_3,e1_5_1,e1_5_2,e1_5_3,e1_6_4,e1_6_1,e1_6_2,e1_6_3) values('$HC','$survey_year','$survey_no','$e1_1_1','$e1_1_2','$e1_1_3','$e1_2_1','$e1_2_2','$e1_2_3','$e1_3_1','$e1_3_2','$e1_3_3','$e1_4_1','$e1_4_2','$e1_4_3','$e1_5_1','$e1_5_2','$e1_5_3','$e1_6_4','$e1_6_1','$e1_6_2','$e1_6_3');";
$mysqli->query($query1);

$query1="update survey_e1 set e1_1_1='$e1_1_1',e1_1_2='$e1_1_2',e1_1_3='$e1_1_3',e1_2_1='$e1_2_1',e1_2_2='$e1_2_2',e1_2_3='$e1_2_3',e1_3_1='$e1_3_1',e1_3_2='$e1_3_2',e1_3_3='$e1_3_3',e1_4_1='$e1_4_1',e1_4_2='$e1_4_2',e1_4_3='$e1_4_3',e1_5_1='$e1_5_1',e1_5_2='$e1_5_2',e1_5_3='$e1_5_3',e1_6_1='$e1_6_1',e1_6_2='$e1_6_2',e1_6_3='$e1_6_3',e1_6_4='$e1_6_4' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);
//echo$query1."<br>";

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 5 1/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveye2'
</script>*/