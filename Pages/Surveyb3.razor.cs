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
$b9_1=$_POST[b9_1];
$b9_2=$_POST[b9_2];
$b9_3=$_POST[b9_3];
$b9_4=$_POST[b9_4];
$b9_5=$_POST[b9_5];
$b9_6=$_POST[b9_6];
$b9_6_1=$_POST[b9_6_1];
$b10=$_POST[b10];
$b10_1=$_POST[b10_1];
$b10_2=$_POST[b10_2];
$b10_3=$_POST[b10_3];
$b10_4=$_POST[b10_4];
$b10_5=$_POST[b10_5];
$b10_6=$_POST[b10_6];
$b10_7=$_POST[b10_7];
$b10_7_1=$_POST[b10_7_1];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}


$query="update survey_b2 set b9_1='$b9_1',b9_2='$b9_2',b9_3='$b9_3',b9_4='$b9_4',b9_5='$b9_5',b9_6='$b9_6',b9_6_1='$b9_6_1',b10='$b10',b10_1='$b10_1',b10_2='$b10_2',b10_3='$b10_3',b10_4='$b10_4',b10_5='$b10_5',b10_6='$b10_6',b10_7='$b10_7',b10_7_1='$b10_7_1' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
//echo$query."<br>";
$mysqli->query($query);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 2 3/4')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyb4'
</script>*/
