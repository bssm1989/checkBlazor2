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
$c1_1_0=$_POST[c1_1_0];
$c1_1_1=$_POST[c1_1_1];
$c1_1_1_1=$_POST[c1_1_1_1];
$c1_1_1_2=$_POST[c1_1_1_2];
$c1_1_2=$_POST[c1_1_2];
$c1_1_2_1=$_POST[c1_1_2_1];
$c1_1_2_2=$_POST[c1_1_2_2];
$c1_1_3=$_POST[c1_1_3];
$c1_1_3_1=$_POST[c1_1_3_1];
$c1_1_3_2=$_POST[c1_1_3_2];
$c1_1_4=$_POST[c1_1_4];
$c1_1_4_1=$_POST[c1_1_4_1];
$c1_1_4_2=$_POST[c1_1_4_2];
$c1_2_0=$_POST[c1_2_0];
$c1_2_1=$_POST[c1_2_1];
$c1_2_1_1=$_POST[c1_2_1_1];
$c1_2_1_2=$_POST[c1_2_1_2];
$c1_2_2=$_POST[c1_2_2];
$c1_2_2_1=$_POST[c1_2_2_1];
$c1_2_2_2=$_POST[c1_2_2_2];
$c1_2_3=$_POST[c1_2_3];
$c1_2_3_1=$_POST[c1_2_3_1];
$c1_2_3_2=$_POST[c1_2_3_2];
$c1_3_0=$_POST[c1_3_0];
$c1_3_1=$_POST[c1_3_1];
$c1_3_1_1=$_POST[c1_3_1_1];
$c1_3_1_2=$_POST[c1_3_1_2];
$c1_3_2=$_POST[c1_3_2];
$c1_3_2_1=$_POST[c1_3_2_1];
$c1_3_2_2=$_POST[c1_3_2_2];
$c2=$_POST[c2];
$c3_1=$_POST[c3_1];
$c3_1_1=$_POST[c3_1_1];
$c3_1_2=$_POST[c3_1_2];
$c3_1_3=$_POST[c3_1_3];
$c3_2=$_POST[c3_2];
$c3_2_1=$_POST[c3_2_1];
$c3_3=$_POST[c3_3];
$c3_3_1=$_POST[c3_3_1];
$c3_4=$_POST[c3_4];
$c3_4_1=$_POST[c3_4_1];
$c3_5=$_POST[c3_5];
$c3_5_1=$_POST[c3_5_1];
$c3_6=$_POST[c3_6];
$c3_6_1=$_POST[c3_6_1];
$c3_7=$_POST[c3_7];
$c3_7_1=$_POST[c3_7_1];
$c3_8=$_POST[c3_8];
$c3_8_1=$_POST[c3_8_1];
$c3_9=$_POST[c3_9];
$c3_9_1=$_POST[c3_9_1];
$c3_10=$_POST[c3_10];
$c3_10_1=$_POST[c3_10_1];
$c3_10_2=$_POST[c3_10_2];
$c4=$_POST[c4];
$c4_1=$_POST[c4_1];
$c4_1_1=$_POST[c4_1_1];
$c4_2=$_POST[c4_2];
$c4_2_1=$_POST[c4_2_1];
$c4_3=$_POST[c4_3];
$c4_3_1=$_POST[c4_3_1];
$c4_4=$_POST[c4_4];
$c4_4_1=$_POST[c4_4_1];
$c4_5=$_POST[c4_5];
$c4_5_1=$_POST[c4_5_1];
$c4_6=$_POST[c4_6];
$c4_6_1=$_POST[c4_6_1];
$c4_6_2=$_POST[c4_6_2];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}


$query="select HC from survey_c1 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_c1 (HC,survey_year,survey_no,c1_1_0,c1_1_1,c1_1_1_1,c1_1_1_2,c1_1_2,c1_1_2_1,c1_1_2_2,c1_1_3,c1_1_3_1,c1_1_3_2,c1_1_4,c1_1_4_1,c1_1_4_2,c1_2_0,c1_2_1,c1_2_1_1,c1_2_1_2,c1_2_2,c1_2_2_1,c1_2_2_2,c1_2_3,c1_2_3_1,c1_2_3_2,c1_3_0,c1_3_1,c1_3_1_1,c1_3_1_2,c1_3_2,c1_3_2_1,c1_3_2_2,c2
,c3_1
,c3_1_1
,c3_1_2
,c3_1_3
,c3_2,c3_2_1,c3_3,c3_3_1,c3_4,c3_4_1,c3_5,c3_5_1,c3_6,c3_6_1,c3_7,c3_7_1,c3_8,c3_8_1,c3_9,c3_9_1,c3_10,c3_10_1,c3_10_2,c4,c4_1,c4_1_1,c4_2,c4_2_1,c4_3,c4_3_1,c4_4,c4_4_1,c4_5,c4_5_1,c4_6,c4_6_1,c4_6_2) values('$HC','$survey_year','$survey_no',	'$c1_1_0','$c1_1_1','$c1_1_1_1','$c1_1_1_2','$c1_1_2','$c1_1_2_1','$c1_1_2_2','$c1_1_3','$c1_1_3_1','$c1_1_3_2','$c1_1_4','$c1_1_4_1','$c1_1_4_2','$c1_2_0','$c1_2_1','$c1_2_1_1','$c1_2_1_2','$c1_2_2','$c1_2_2_1','$c1_2_2_2','$c1_2_3','$c1_2_3_1','$c1_2_3_2','$c1_3_0','$c1_3_1','$c1_3_1_1','$c1_3_1_2','$c1_3_2','$c1_3_2_1','$c1_3_2_2','$c2'

,'$c3_1'
,'$c3_1_1'
,'$c3_1_2'
,'$c3_1_3'


,'$c3_2','$c3_2_1','$c3_3','$c3_3_1','$c3_4','$c3_4_1','$c3_5','$c3_5_1','$c3_6','$c3_6_1','$c3_7','$c3_7_1','$c3_8','$c3_8_1','$c3_9','$c3_9_1','$c3_10','$c3_10_1','$c3_10_2','$c4','$c4_1','$c4_1_1','$c4_2','$c4_2_1','$c4_3','$c4_3_1','$c4_4','$c4_4_1','$c4_5','$c4_5_1','$c4_6','$c4_6_1','$c4_6_2');";
$mysqli->query($query1);

$query1="update survey_c1 set c1_1_0='$c1_1_0',c1_1_1='$c1_1_1',c1_1_1_1='$c1_1_1_1',c1_1_1_2='$c1_1_1_2',c1_1_2='$c1_1_2',c1_1_2_1='$c1_1_2_1',c1_1_2_2='$c1_1_2_2',c1_1_3='$c1_1_3',c1_1_3_1='$c1_1_3_1',c1_1_3_2='$c1_1_3_2',c1_1_4='$c1_1_4',c1_1_4_1='$c1_1_4_1',c1_1_4_2='$c1_1_4_2',c1_2_0='$c1_2_0',c1_2_1='$c1_2_1',c1_2_1_1='$c1_2_1_1',c1_2_1_2='$c1_2_1_2',c1_2_2='$c1_2_2',c1_2_2_1='$c1_2_2_1',c1_2_2_2='$c1_2_2_2',c1_2_3='$c1_2_3',c1_2_3_1='$c1_2_3_1',c1_2_3_2='$c1_2_3_2',c1_3_0='$c1_3_0',c1_3_1='$c1_3_1',c1_3_1_1='$c1_3_1_1',c1_3_1_2='$c1_3_1_2',c1_3_2='$c1_3_2',c1_3_2_1='$c1_3_2_1',c1_3_2_2='$c1_3_2_2',c2='$c2'
,c3_1='$c3_1'
,c3_1_1='$c3_1_1'
,c3_1_2='$c3_1_2'
,c3_1_3='$c3_1_3'

,c3_2='$c3_2',c3_2_1='$c3_2_1',c3_3='$c3_3',c3_3_1='$c3_3_1',c3_4='$c3_4',c3_4_1='$c3_4_1',c3_5='$c3_5',c3_5_1='$c3_5_1',c3_6='$c3_6',c3_6_1='$c3_6_1',c3_7='$c3_7',c3_7_1='$c3_7_1',c3_8='$c3_8',c3_8_1='$c3_8_1',c3_9='$c3_9',c3_9_1='$c3_9_1',c3_10='$c3_10',c3_10_1='$c3_10_1',c3_10_2='$c3_10_2',c4='$c4',c4_1='$c4_1',c4_1_1='$c4_1_1',c4_2='$c4_2',c4_2_1='$c4_2_1',c4_3='$c4_3',c4_3_1='$c4_3_1',c4_4='$c4_4',c4_4_1='$c4_4_1',c4_5='$c4_5',c4_5_1='$c4_5_1',c4_6='$c4_6',c4_6_1='$c4_6_1',c4_6_2='$c4_6_2' where HC='$HC'  and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);


//echo$query1."<br>";
//$mysqli->query($query1);
$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 3 1/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyc2'
</script>*/