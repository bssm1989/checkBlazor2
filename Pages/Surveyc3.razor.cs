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
$c6=$_POST[c6];
$c6_1=$_POST[c6_1];
$c6_2=$_POST[c6_2];
$c6_3=$_POST[c6_3];
$c6_4=$_POST[c6_4];
$c6_5=$_POST[c6_5];
$c6_6=$_POST[c6_6];
$c6_7=$_POST[c6_7];
$c6_8=$_POST[c6_8];
$c6_9=$_POST[c6_9];
$c6_10=$_POST[c6_10];
$c6_11=$_POST[c6_11];
$c6_11_1=$_POST[c6_11_1];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}


$query1="update survey_c1 set c6='$c6',c6_1='$c6_1',c6_2='$c6_2',c6_3='$c6_3',c6_4='$c6_4',c6_5='$c6_5',c6_6='$c6_6',c6_7='$c6_7',c6_8='$c6_8',c6_9='$c6_9',c6_10='$c6_10',c6_11='$c6_11',c6_11_1='$c6_11_1' where HC='$HC'  and survey_year='$survey_year' and survey_no='$survey_no'";

//echo$query1."<br>";
$mysqli->query($query1);

$query_up1="update survey_staff set ch3_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 3 3/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyd1'
</script>*/