/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
//exit();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
$b8_0=$_POST[b8_0];
if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$HC=$_SESSION["HC"];
;
$b8_1=$_POST[b8_1];
$b8_1_1=$_POST[b8_1_1];
$b8_1_2=$_POST[b8_1_2];
$b8_1_3=$_POST[b8_1_3];
$b8_1_4=$_POST[b8_1_4];
$b8_1_1_1=$_POST[b8_1_1_1];
$b8_1_1_2=$_POST[b8_1_1_2];
$b8_1_1_3=$_POST[b8_1_1_3];
$b8_1_1_4=$_POST[b8_1_1_4];
$b8_1_1_5=$_POST[b8_1_1_5];
$b8_1_1_6=$_POST[b8_1_1_6];
$b8_2=$_POST[b8_2];
$b8_2_1=$_POST[b8_2_1];
$b8_2_2=$_POST[b8_2_2];
$b8_2_3=$_POST[b8_2_3];
$b8_2_4=$_POST[b8_2_4];
$b8_3=$_POST[b8_3];
$b8_3_1=$_POST[b8_3_1];
$b8_3_2=$_POST[b8_3_2];
$b8_3_3=$_POST[b8_3_3];
$b8_3_4=$_POST[b8_3_4];
$b8_4=$_POST[b8_4];
$b8_5=$_POST[b8_5];
$b8_5_1=$_POST[b8_5_1];
$b8_5_2=$_POST[b8_5_2];
$b8_5_3=$_POST[b8_5_3];
$b8_5_4=$_POST[b8_5_4];
$b8_5_5=$_POST[b8_5_5];
$b8_5_6=$_POST[b8_5_6];

$b8_6=$_POST[b8_6];
$b8_6_1=$_POST[b8_6_1];
$b8_6_2=$_POST[b8_6_2];
$b8_6_3=$_POST[b8_6_3];
$b8_6_4=$_POST[b8_6_4];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}


$query="select HC from survey_b2 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_b2 (HC,survey_year,survey_no,b8_0,b8_1,b8_1_1,b8_1_2,b8_1_3,b8_1_4,b8_1_1_1,b8_1_1_2,b8_1_1_3,b8_1_1_4,b8_1_1_5,b8_1_1_6,b8_2,b8_2_1,b8_2_2,b8_2_3,b8_2_4,
b8_3,b8_3_1,b8_3_2,b8_3_3,b8_3_4,b8_4,b8_5,b8_5_1,b8_5_2,b8_5_3,b8_5_4,b8_5_5,b8_5_6,
b8_6,b8_6_1,b8_6_2,b8_6_3,b8_6_4
) values('$HC','$survey_year','$survey_no','$b8_0','$b8_1','$b8_1_1','$b8_1_2','$b8_1_3','$b8_1_4','$b8_1_1_1','$b8_1_1_2','$b8_1_1_3','$b8_1_1_4','$b8_1_1_5','$b8_1_1_6','$b8_2','$b8_2_1','$b8_2_2','$b8_2_3','$b8_2_4',
'$b8_3','$b8_3_1','$b8_3_2','$b8_3_3','$b8_3_4','$b8_4','$b8_5','$b8_5_1','$b8_5_2','$b8_5_3','$b8_5_4','$b8_5_5','$b8_5_6',
'$b8_6','$b8_6_1','$b8_6_2','$b8_6_3','$b8_6_4');";
$mysqli->query($query1);

	$query1="update survey_b2 set b8_0='$b8_0',b8_1='$b8_1',b8_1_1='$b8_1_1',b8_1_2='$b8_1_2',b8_1_3='$b8_1_3',b8_1_4='$b8_1_4',b8_1_1_1='$b8_1_1_1',b8_1_1_2='$b8_1_1_2',b8_1_1_3='$b8_1_1_3',b8_1_1_4='$b8_1_1_4',b8_1_1_5='$b8_1_1_5',b8_1_1_6='$b8_1_1_6',b8_2='$b8_2',b8_2_1='$b8_2_1',b8_2_2='$b8_2_2',b8_2_3='$b8_2_3',b8_2_4='$b8_2_4',
b8_3='$b8_3',b8_3_1='$b8_3_1',b8_3_2='$b8_3_2',b8_3_3='$b8_3_3',b8_3_4='$b8_3_4',b8_4='$b8_4',b8_5='$b8_5',b8_5_1='$b8_5_1',b8_5_2='$b8_5_2',b8_5_3='$b8_5_3',b8_5_4='$b8_5_4',b8_5_5='$b8_5_5',b8_5_6='$b8_5_6',
b8_6='$b8_6',b8_6_1='$b8_6_1',b8_6_2='$b8_6_2',b8_6_3='$b8_6_3',b8_6_4='$b8_6_4'
where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 2 2/4')";
$result_log=$mysqli->query($log);

//echo$query1."<br>";

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
if($b8_0=='0'){
?>
<script>
	location='index.php?curr=surveyb4'
</script>*/
/*<?php
}else{
?>
<script>
	location='index.php?curr=surveyb3'
</script>*/
/*<?php
}
?>*/
