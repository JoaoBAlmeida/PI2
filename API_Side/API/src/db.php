<?php
	if (PHP_SAPI != 'cli') {
	    exit("Rodar via CLI");
	}

	require __DIR__ . '/../vendor/autoload.php';
	use Carbon\Carbon;

	session_start();

	// Instantiate the app
	$settings = require __DIR__ . '/../src/settings.php';
	$app = new \Slim\App($settings);

	// Set up dependencies
	require __DIR__ . '/../src/dependencies.php';

	//Work with database
	$db = $container->get('db');
	$schema = $db->schema();

	/*================================================================
	Working with table suicides
	================================================================*/
	$tabela = 'suicides';
	$schema->dropIfExists($tabela);

	//Create table
	$schema->create($tabela, function($table){
		$table->increments('id');
		$table->string('country');
		$table->integer('year');
		$table->string('sex');
		$table->string('age');
		$table->integer('suicides_no');
		$table->integer('population');
		$table->decimal('suicides/100k pop', 11,2);
		$table->string('country-year');
		$table->decimal('HDI for year', 11,2);
		$table->string('gdp_for_year ($)');
		$table->string('gdp_per_capita ($)');
		$table->string('generation');
		$table->timestamps();
	});
?>