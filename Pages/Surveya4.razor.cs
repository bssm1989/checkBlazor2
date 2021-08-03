/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
//exit();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
$username=$_COOKIE[username_log];

if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$HC=$_SESSION["HC"];
$a1=$_POST[a1];

$a14=$_POST[a14];
$a15_0=$_POST[a15_0];
$a15_0_1=$_POST[a15_0_1];
$a15_0_1_1=$_POST[a15_0_1_1];
$a15_0_1_2=$_POST[a15_0_1_2];
$a15_0_1_3=$_POST[a15_0_1_3];
$a15_0_1_4=$_POST[a15_0_1_4];
$a15_0_1_5=$_POST[a15_0_1_5];
$a15_0_1_6=$_POST[a15_0_1_6];
$a15_0_1_7=$_POST[a15_0_1_7];
$a15_0_1_7_1=$_POST[a15_0_1_7_1];
$a15_0_2=$_POST[a15_0_2];
$a15_0_2_1=$_POST[a15_0_2_1];
$a15_0_2_2=$_POST[a15_0_2_2];
$a15_0_2_3=$_POST[a15_0_2_3];
$a15_0_2_4=$_POST[a15_0_2_4];
$a15_0_2_5=$_POST[a15_0_2_5];
$a15_0_2_6=$_POST[a15_0_2_6];
$a15_0_2_7=$_POST[a15_0_2_7];
$a15_0_2_7_1=$_POST[a15_0_2_7_1];
$a15_1=$_POST[a15_1];
$a15_2=$_POST[a15_2];
$a15_3=$_POST[a15_3];
$a15_4=$_POST[a15_4];
$a15_5=$_POST[a15_5];
$a15_6=$_POST[a15_6];
$a15_7=$_POST[a15_7];
$a15_8=$_POST[a15_8];
$a15_9=$_POST[a15_9];
$a15_10=$_POST[a15_10];
$a15_10_1=$_POST[a15_10_1];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}


$count=count($a1);
for($i=1;$i<=$count;$i++){//for($i=1;$i<=$count;$i++){
	$query="insert into survey_a2 (HC,survey_year,survey_no,a1,a14,a15_0,a15_0_1,a15_0_1_1,a15_0_1_2,a15_0_1_3,a15_0_1_4,a15_0_1_5,a15_0_1_6,a15_0_1_7,a15_0_1_7_1,a15_0_2,a15_0_2_1,a15_0_2_2,a15_0_2_3,a15_0_2_4,a15_0_2_5,a15_0_2_6,a15_0_2_7,a15_0_2_7_1,a15_1,a15_2,a15_3,a15_4,a15_5,a15_6,a15_7,a15_8,a15_9,a15_10,a15_10_1) values('$HC','$survey_year','$survey_no','$a1[$i]','$a14[$i]','$a15_0[$i]','$a15_0_1[$i]','$a15_0_1_1[$i]','$a15_0_1_2[$i]','$a15_0_1_3[$i]','$a15_0_1_4[$i]','$a15_0_1_5[$i]','$a15_0_1_6[$i]','$a15_0_1_7[$i]','$a15_0_1_7_1[$i]','$a15_0_2[$i]','$a15_0_2_1[$i]','$a15_0_2_2[$i]','$a15_0_2_3[$i]','$a15_0_2_4[$i]','$a15_0_2_5[$i]','$a15_0_2_6[$i]','$a15_0_2_7[$i]','$a15_0_2_7_1[$i]','$a15_1[$i]','$a15_2[$i]','$a15_3[$i]','$a15_4[$i]','$a15_5[$i]','$a15_6[$i]','$a15_7[$i]','$a15_8[$i]','$a15_9[$i]','$a15_10[$i]','$a15_10_1[$i]')";
//echo$query."<br>";
	$mysqli->query($query);
	
	$query="update survey_a2 set a14='$a14[$i]',a15_0='$a15_0[$i]',a15_0_1='$a15_0_1[$i]',a15_0_1_1='$a15_0_1_1[$i]',a15_0_1_2='$a15_0_1_2[$i]',a15_0_1_3='$a15_0_1_3[$i]',a15_0_1_4='$a15_0_1_4[$i]',a15_0_1_5='$a15_0_1_5[$i]',a15_0_1_6='$a15_0_1_6[$i]',a15_0_1_7='$a15_0_1_7[$i]',a15_0_1_7_1='$a15_0_1_7_1[$i]',a15_0_2='$a15_0_2[$i]',a15_0_2_1='$a15_0_2_1[$i]',a15_0_2_2='$a15_0_2_2[$i]',a15_0_2_3='$a15_0_2_3[$i]',a15_0_2_4='$a15_0_2_4[$i]',a15_0_2_5='$a15_0_2_5[$i]',a15_0_2_6='$a15_0_2_6[$i]',a15_0_2_7='$a15_0_2_7[$i]',a15_0_2_7_1='$a15_0_2_7_1[$i]',a15_1='$a15_1[$i]',a15_2='$a15_2[$i]',a15_3='$a15_3[$i]',a15_4='$a15_4[$i]',a15_5='$a15_5[$i]',a15_6='$a15_6[$i]',a15_7='$a15_7[$i]',a15_8='$a15_8[$i]',a15_9='$a15_9[$i]',a15_10='$a15_10[$i]',a15_10_1='$a15_10_1[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
	$mysqli->query($query);
//echo$query."<br>";
	$mysqli->query($query);
}

$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 4/5')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveya5'
</script>*/