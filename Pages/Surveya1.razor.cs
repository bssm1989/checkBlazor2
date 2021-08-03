/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
$username=$_COOKIE[username_log];

if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$a1=$_POST[a1];
$a2=$_POST[a2];
$a2_b=$_POST[date1];
$popid=$_POST[popid];
$a3=$_POST[a3];
$a4=$_POST[a4];
$a5=$_POST[a5];
$a6=$_POST[a6];
$HC=$_SESSION[HC];
$del=$_POST[del];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$count=count($a1);
for($i=1;$i<=$count;$i++){
	if($del[$i]){//if($del[$i]){
		$query="delete from survey_a1 where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
		$result=$mysqli->query($query);

		$query="delete from survey_a2 where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
		$result=$mysqli->query($query);
	}else{//if($del[$i]){
		if($a2[$i]){//if($a1[$i]){
			$query1="insert into survey_a1(HC,survey_year,survey_no,a1,a2,popid,a3,a4,a5,a6,a2_b) values('$HC','$survey_year','$survey_no','$a1[$i]','$a2[$i]','$popid[$i]','$a3[$i]','$a4[$i]','$a5[$i]','$a6[$i]','$a2_b[$i]');";
			$mysqli->query($query1);
//echo$query1."<br>";

			$query1="insert into survey_a2(HC,survey_year,survey_no,a1,a5) values('$HC','$survey_year','$survey_no','$a1[$i]','$a5[$i]');";
			$mysqli->query($query1);


			$query1="update survey_a1 set a2='$a2[$i]',popid='$popid[$i]',a3='$a3[$i]',a4='$a4[$i]',a5='$a5[$i]',a6='$a6[$i]',a2_b='$a2_b[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			$mysqli->query($query1);

			$query1="update survey_a2 set a5='$a5[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			$mysqli->query($query1);

//echo$query1."<br>";
		}
	}//if($del[$i]){
}

$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 1/5')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);

$query_up="select ch1 from survey_staff where  HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up=$mysqli->query($query_up);
if($result_up->ch1){
	$query_up1="update survey_staff set ch1_st='".date("U")."' where  HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
	$result_up1=$mysqli->query($query_up1);
}


exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
//exit();


$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveya2'
</script>*/