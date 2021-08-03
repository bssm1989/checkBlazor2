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

$a16_0=$_POST[a16_0];
$a16_1=$_POST[a16_1];
$a16_2=$_POST[a16_2];
$a16_3=$_POST[a16_3];
$a16_4=$_POST[a16_4];
$a16_5=$_POST[a16_5];
$a16_6=$_POST[a16_6];
$a16_7=$_POST[a16_7];
$a16_8=$_POST[a16_8];
$a16_9=$_POST[a16_9];
$a16_10=$_POST[a16_10];
$a16_10_1=$_POST[a16_10_1];
$a17_1=$_POST[a17_1];
$a17_2=$_POST[a17_2];
$a17_3_1=$_POST[a17_3_1];
$a17_3_2=$_POST[a17_3_2];

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
	$query="update survey_a2 set a16_0='$a16_0[$i]',a16_1='$a16_1[$i]',a16_2='$a16_2[$i]',a16_3='$a16_3[$i]',a16_4='$a16_4[$i]',a16_5='$a16_5[$i]',a16_6='$a16_6[$i]',a16_7='$a16_7[$i]',a16_8='$a16_8[$i]',a16_9='$a16_9[$i]',a16_10='$a16_10[$i]',a16_10_1='$a16_10_1[$i]',a17_1='$a17_1[$i]',a17_2='$a17_2[$i]',a17_3_1='$a17_3_1[$i]',a17_3_2='$a17_3_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
//	echo$query."<br>";
	$mysqli->query($query);
}

$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 5/5')";
$result_log=$mysqli->query($log);

$query_up1="update survey_staff set ch1_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyb1'
</script>*/