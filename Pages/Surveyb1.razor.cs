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
$b1_1=$_POST[b1_1];
$b1_2=$_POST[b1_2];
$b2=$_POST[b2];
$b2_2=$_POST[b2_2];
$b2_3=$_POST[b2_3];
$b2_4_1=$_POST[b2_4_1];
$b2_4_1_1=$_POST[b2_4_1_1];
$b2_4_1_2=$_POST[b2_4_1_2];
$b2_4_1_3=$_POST[b2_4_1_3];
$b2_4_2=$_POST[b2_4_2];
$b2_4_2_1=$_POST[b2_4_2_1];
$b2_4_2_2=$_POST[b2_4_2_2];
$b2_4_2_3=$_POST[b2_4_2_3];
$b2_4_3=$_POST[b2_4_3];
$b2_4_3_1=$_POST[b2_4_3_1];
$b2_4_3_2=$_POST[b2_4_3_2];
$b2_4_3_3=$_POST[b2_4_3_3];
$b2_4_4=$_POST[b2_4_4];
$b2_4_4_1=$_POST[b2_4_4_1];
$b2_4_4_2=$_POST[b2_4_4_2];
$b2_4_4_3=$_POST[b2_4_4_3];
$b3=$_POST[b3];
$b4_1=$_POST[b4_1];
$b4_2=$_POST[b4_2];
$b4_3=$_POST[b4_3];
$b4_4=$_POST[b4_4];
$b5_1=$_POST[b5_1];
$b5_2=$_POST[b5_2];
$b6_1=$_POST[b6_1];
$b6_2=$_POST[b6_2];
$b6_3=$_POST[b6_3];
$b7_1=$_POST[b7_1];
$b7_1_1=$_POST[b7_1_1];

$b7_2=$_POST[b7_2];
$b7_2_1=$_POST[b7_2_1];
$b7_2_1_1=$_POST[b7_2_1_1];
$b7_2_2=$_POST[b7_2_2];
$b7_2_2_1=$_POST[b7_2_2_1];

$b7_3=$_POST[b7_3];
$b7_3_1=$_POST[b7_3_1];
$b7_3_1_1=$_POST[b7_3_1_1];
$b7_3_2=$_POST[b7_3_2];
$b7_3_2_1=$_POST[b7_3_2_1];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

if(empty($b1_1) || empty($b1_2)){
	$qu="select HC from survey_profile where HC='$HC' and lat ='' and lng ='' ";
	$re=$mysqli->query($qu);
	$ro=$re->fetch_object();

	if($ro->HC){
		$query_local="select lat,lng from jun_location where JUN='$row_HC->JUN'";
		$result_local=$mysqli->query($query_local);
		$row_local=$result_local->fetch_object();
		$lat=$row_local->lat;
		$lng=$row_local->lng;
		$rand1=rand(-1000,1000);
		$rand2=rand(-1000,1000);
		$lat2=$rand1/1000000;
		$lng2=$rand2/1000000;
		$lat1=$lat+$lat2;
		$lng1=$lng+$lng2;	

		$update1="update survey_profile set lat='$lat1',lng='$lng1' where HC='$HC'";
		$mysqli->query($update1);
	}
}else{
	$qu="select HC from survey_profile where HC='$HC' and lat ='' and lng ='' ";
	$re=$mysqli->query($qu);
	$ro=$re->fetch_object();

	if($ro->HC){
		$update1="update survey_profile set lat='$b1_1',lng='$b1_2' where HC='$HC'";
		$mysqli->query($update1);
	}
}

$query1="insert into survey_b1 (HC,survey_year,survey_no,b1_1,b1_2	,b2,b2_2,b2_3,b2_4_1,b2_4_1_1,b2_4_1_2,b2_4_1_3,b2_4_2,b2_4_2_1,b2_4_2_2,b2_4_2_3,b2_4_3,b2_4_3_1,b2_4_3_2,b2_4_3_3,b2_4_4,b2_4_4_1,b2_4_4_2,b2_4_4_3,b3,b4_1,b4_2,b4_3,b4_4,b5_1,b5_2,b6_1,b6_2,b6_3,b7_1,b7_1_1
,b7_2
,b7_2_1
,b7_2_1_1
,b7_2_2
,b7_2_2_1

,b7_3
,b7_3_1
,b7_3_1_1
,b7_3_2
,b7_3_2_1


)values('$HC','$survey_year','$survey_no','$b1_1','$b1_2','$b2','$b2_2','$b2_3','$b2_4_1','$b2_4_1_1','$b2_4_1_2','$b2_4_1_3','$b2_4_2','$b2_4_2_1','$b2_4_2_2','$b2_4_2_3','$b2_4_3','$b2_4_3_1','$b2_4_3_2','$b2_4_3_3','$b2_4_4','$b2_4_4_1','$b2_4_4_2','$b2_4_4_3','$b3','$b4_1','$b4_2','$b4_3','$b4_4','$b5_1','$b5_2','$b6_1','$b6_2','$b6_3','$b7_1','$b7_1_1'

,'$b7_2'
,'$b7_2_1'
,'$b7_2_1_1'
,'$b7_2_2'
,'$b7_2_2_1'

,'$b7_3'
,'$b7_3_1'
,'$b7_3_1_1'
,'$b7_3_2'
,'$b7_3_2_1'

);";
$mysqli->query($query1);

$query1="update survey_b1 set b2='$b2',b2_2='$b2_2',b2_3='$b2_3',b2_4_1='$b2_4_1',b2_4_1_1='$b2_4_1_1',b2_4_1_2='$b2_4_1_2',b2_4_1_3='$b2_4_1_3',b2_4_2='$b2_4_2',b2_4_2_1='$b2_4_2_1',b2_4_2_2='$b2_4_2_2',b2_4_2_3='$b2_4_2_3',b2_4_3='$b2_4_3',b2_4_3_1='$b2_4_3_1',b2_4_3_2='$b2_4_3_2',b2_4_3_3='$b2_4_3_3',b2_4_4='$b2_4_4',b2_4_4_1='$b2_4_4_1',b2_4_4_2='$b2_4_4_2',b2_4_4_3='$b2_4_4_3',b3='$b3',b4_1='$b4_1',b4_2='$b4_2',b4_3='$b4_3',b4_4='$b4_4',b5_1='$b5_1',b5_2='$b5_2',b6_1='$b6_1',b6_2='$b6_2',b6_3='$b6_3',b7_1='$b7_1',b7_1_1='$b7_1_1'
,b7_2='$b7_2'
,b7_2_1='$b7_2_1'
,b7_2_1_1='$b7_2_1_1'
,b7_2_2='$b7_2_2'
,b7_2_2_1='$b7_2_2_1'

,b7_3='$b7_3'
,b7_3_1='$b7_3_1'
,b7_3_1_1='$b7_3_1_1'
,b7_3_2='$b7_3_2'
,b7_3_2_1='$b7_3_2_1'
 where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";

$mysqli->query($query1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 2 1/4')";
$result_log=$mysqli->query($log);

$query3="select HC,TMP from survey_profile where HC='$HC' and (lat='' or lng='' or lat is NULL or lng is NULL)";
$result3=$mysqli->query($query3);
$row3=$result3->fetch_object();
if($row3->HC){
	if(empty($b1_1) || empty($b1_2)){
		$qu_tmp="select tambon_name_thai,lat,lng from tambon where tambon_id='$row3->TMP'";
		$re_tmp=$mysqli->query($qu_tmp);
		$ro_tmp=$re_tmp->fetch_object();

		$rand1=rand(-1000,1000);
		$rand2=rand(-1000,1000);
		$lat2=$rand1/1000000;
		$lng2=$rand2/1000000;
		$lat2=$ro_tmp->lat+$lat2;
		$lng2=$ro_tmp->lng+$lng2;
		$query_up="update survey_profile set lat='$lat2',lng='$lng2' where HC='$HC';";
	}else{
		$query_up="update survey_profile set lat='$b1_1',lng='$b1_2' where HC='$HC'";
	}
	$mysqli->query($query_up);
}
//echo$query1."<br>";

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyb2'
</script>*/

