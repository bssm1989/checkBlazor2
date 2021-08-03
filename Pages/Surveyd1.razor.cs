/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
//exit();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
$gps=str_replace("'","\'",$_POST["gps"]);
if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$HC=$_SESSION["HC"];
$d1_1=$_POST[d1_1];
$d1_2=$_POST[d1_2];
$d2=$_POST[d2];
$d2_1=$_POST[d2_1];
$d2_2=$_POST[d2_2];
$d2_3=$_POST[d2_3];
$d2_3_1=$_POST[d2_3_1];
$d3=$_POST[d3];
$d3_1=$_POST[d3_1];
$d3_2=$_POST[d3_2];
$d3_3=$_POST[d3_3];
$d3_3_1=$_POST[d3_3_1];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$query="select HC from survey_d1 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_d1 (HC,survey_year,survey_no,d1_1,d1_2,d2,d2_1,d2_2,d2_3,d2_3_1,d3,d3_1,d3_2,d3_3,d3_3_1) values('$HC','$survey_year','$survey_no','$d1_1','$d1_2','$d2','$d2_1','$d2_2','$d2_3','$d2_3_1','$d3','$d3_1','$d3_2','$d3_3','$d3_3_1');";
$mysqli->query($query1);

$query1="update survey_d1 set d2='$d2',d2_1='$d2_1',d2_2='$d2_2',d2_3='$d2_3',d2_3_1='$d2_3_1',d3='$d3',d3_1='$d3_1',d3_2='$d3_2',d3_3='$d3_3',d3_3_1='$d3_3_1'
where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);

//echo$query1."<br>";
$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 4 1/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyd2'
</script>*/