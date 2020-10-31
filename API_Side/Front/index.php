<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<?php
			session_start(); 
			require_once "Scripts/linksHead.php";
		?>
			
		<title>Project 01</title>
	</head>
	<body>
		<?php require_once "Scripts/linksBody.php" ?>

		<!-- Since scripts require JQuery, they were called after linksBody-->

		<!-- Ajax Script -->
		<script type="text/javascript" src="js/ajax.js"></script>

		<header class="sticky-top">
			<div id="logo">
				<h2>P.I. Secondo</h2>
			</div>
		</header>

		<aside class="bg-primary sidebar">
			<div class="row">
				<div class="col-md-12">
					<ul class="">
						<li class="">
							<hr>
						</li>
						<li class="">
							<a class="" href="#" onclick="requestPage('Pages/csvUP.php');">Add CSV Data</a>	
						</li>
						<li class="">
							<hr>
						</li>
					</ul>
				</div>
			</div>
		</aside>

		<section id="contentPage">

		</section>

		<?php if(isset($_GET['success']) && $_GET['success'] == "true"){ ?>
			<script type="text/javascript">
				requestPage('Pages/csvUP.php?success=true');
			</script>
		<?php }
			else if(isset($_GET['success']) && $_GET['success'] == "false"){ ?>
			<script type="text/javascript">
				requestPage('Pages/csvUP.php?success=false');
			</script>
		<?php } 
			else { ?>
			<script type="text/javascript">
				requestPage('Pages/csvUP.php');
			</script>
		<?php } ?>
	</body>
</html>