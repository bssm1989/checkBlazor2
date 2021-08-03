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
$a7_0=$_POST[a7_0];
$a7_1=$_POST[a7_1];
$a7_1_1=$_POST[a7_1_1];
$a7_1_2=$_POST[a7_1_2];
$a7_2=$_POST[a7_2];
$a7_2_1=$_POST[a7_2_1];
$a7_2_2=$_POST[a7_2_2];
$a7_3=$_POST[a7_3];
$a7_3_1=$_POST[a7_3_1];
$a7_3_2=$_POST[a7_3_2];
$a7_4=$_POST[a7_4];
$a7_4_1=$_POST[a7_4_1];
$a7_4_2=$_POST[a7_4_2];
$a7_5=$_POST[a7_5];
$a7_5_1=$_POST[a7_5_1];
$a7_5_2=$_POST[a7_5_2];
$a7_6=$_POST[a7_6];
$a7_6_1=$_POST[a7_6_1];
$a7_6_2=$_POST[a7_6_2];
$a7_7=$_POST[a7_7];
$a7_7_1=$_POST[a7_7_1];
$a7_7_2=$_POST[a7_7_2];
$a7_8=$_POST[a7_8];
$a7_8_1=$_POST[a7_8_1];
$a7_8_2=$_POST[a7_8_2];

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
	$ua7_8='';
//	echo$i;
	$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
//	echo$query."<br>";
	$mysqli->query($query);

}//for($i=1;$i<=$count;$i++){

$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 2/5')";
$result_log=$mysqli->query($log);

//exit();
$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveya3'
</script>*/