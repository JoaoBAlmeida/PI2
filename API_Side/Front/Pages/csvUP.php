<div class="container">
	<div class="row">
		<div class="col">
			<div class="card">
				<div class="card-body">
					<form method="POST" enctype="multipart/form-data" action="http://localhost/PI2/API/public/namep/fileupload/">
						<fieldset class="form-group">
							<label for="csvFileLoader">Upload CSV:</label>
							<input type="file" name="file" id="csvFileLoader" required accept=".csv" class="form-control-file">
						</fieldset>
						<input class="btn btn-outline-info btn-block" type="submit" name="upload" value="Upload">
						<?php if(isset($_GET['success']) && $_GET['success'] == "true"){ ?>
							<small class="text-success">File Uploaded</small>
						<?php }
							if(isset($_GET['success']) && $_GET['success'] == "false"){ ?>
							<small class="text-danger">Error Uploading</small>
						<?php } ?>
					</form>
				</div>
			</div>
		</div>
	</div>
</div>