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
$e2_1_1=$_POST[e2_1_1];
$e2_1_2=$_POST[e2_1_2];
$e2_1_3=$_POST[e2_1_3];
$e2_1_4=$_POST[e2_1_4];
$e2_2_1=$_POST[e2_2_1];
$e2_2_2=$_POST[e2_2_2];
$e2_2_3=$_POST[e2_2_3];
$e2_2_4=$_POST[e2_2_4];
$e2_3_1=$_POST[e2_3_1];
$e2_3_2=$_POST[e2_3_2];
$e2_3_3=$_POST[e2_3_3];
$e2_3_4=$_POST[e2_3_4];
$e2_4_1=$_POST[e2_4_1];
$e2_4_2=$_POST[e2_4_2];
$e2_4_3=$_POST[e2_4_3];
$e2_4_4=$_POST[e2_4_4];
$e2_5_5=$_POST[e2_5_5];
$e2_5_1=$_POST[e2_5_1];
$e2_5_2=$_POST[e2_5_2];
$e2_5_3=$_POST[e2_5_3];
$e2_5_4=$_POST[e2_5_4];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$query1="insert into survey_e2 (HC,survey_year,survey_no,e2_1_1,e2_1_2,e2_1_3,e2_1_4,e2_2_1,e2_2_2,e2_2_3,e2_2_4,e2_3_1,e2_3_2,e2_3_3,e2_3_4,e2_4_1,e2_4_2,e2_4_3,e2_4_4,e2_5_5,e2_5_1,e2_5_2,e2_5_3,e2_5_4) values('$HC','$survey_year','$survey_no','$e2_1_1','$e2_1_2','$e2_1_3','$e2_1_4','$e2_2_1','$e2_2_2','$e2_2_3','$e2_2_4','$e2_3_1','$e2_3_2','$e2_3_3','$e2_3_4','$e2_4_1','$e2_4_2','$e2_4_3','$e2_4_4','$e2_5_5','$e2_5_1','$e2_5_2','$e2_5_3','$e2_5_4');";
$mysqli->query($query1);


$query1="update survey_e2 set e2_1_1='$e2_1_1',e2_1_2='$e2_1_2',e2_1_3='$e2_1_3',e2_1_4='$e2_1_4',e2_2_1='$e2_2_1',e2_2_2='$e2_2_2',e2_2_3='$e2_2_3',e2_2_4='$e2_2_4',e2_3_1='$e2_3_1',e2_3_2='$e2_3_2',e2_3_3='$e2_3_3',e2_3_4='$e2_3_4',e2_4_1='$e2_4_1',e2_4_2='$e2_4_2',e2_4_3='$e2_4_3',e2_4_4='$e2_4_4',e2_5_5='$e2_5_5',e2_5_1='$e2_5_1',e2_5_2='$e2_5_2',e2_5_3='$e2_5_3',e2_5_4='$e2_5_4' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);


//echo$query1."<br>";

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 5 2/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveye3'
</script>*/