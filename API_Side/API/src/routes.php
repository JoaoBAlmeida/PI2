<?php

use Slim\Http\Request;
use Slim\Http\Response;
use App\Models\Suicide;
use Carbon\Carbon;
use League\Csv\Reader;

ini_set('max_execution_time', 300);
// Routes

$app->group('/namep', function () {
    //Get CSV file and call upload function
    $this->post('/fileupload/', function($request, $response){
		if(isset($_POST['upload'])){
			$file = $_FILES['file']['tmp_name'];
			$csv = Reader::createFromPath($file, 'r')
				->setHeaderOffset(0);

			foreach ($csv as $record) {
				$state = suicideme($record);
				if(!$state) return $response->withRedirect("http://localhost/PI2/Front/index.php?success=false", 301);
			}

			return $response->withRedirect("http://localhost/PI2/Front/index.php?success=true", 301);

		}
	});
	/*===========================
	Collect info by ONE certain aspect
	============================*/

	$this->get('/getbyyear/{year}[/{compare}]', function($request, $response, $args){
		$year = $request->getAttribute('year');
		$compare = checkCompare($request->getAttribute('compare'));
		$suicideYear = Suicide::where('year', $compare, $year)->get();
		return $response->withJson($suicideYear);
	})->setArgument('compare', '=');

	$this->get('/getbycountry/{country}', function($request, $response){
		$country = $request->getAttribute('country');
		$suicide_country = Suicide::where('country', $country)->get();
		return $response->withJson($suicide_country);
	});

	$this->get('/getbysex/{sex}', function($request, $response){
		$sex = $request->getAttribute('sex');
		$suicide_sex = Suicide::where('sex', $sex)->get();
		return $response->withJson($suicide_sex);
	});

	$this->get('/getbyage/{lower_age}_{higher_age}', function($request, $response){
		$age = $request->getAttribute('lower_age') . '-' . $request->getAttribute('higher_age');
		$suicide_age = Suicide::where('age', $age . ' years')->get();
		return $response->withJson($suicide_age);
	});

	$this->get('/getbysuicides/{number}[/{compare}]', function($request, $response, $args){
		$suicides_no = $request->getAttribute('number');
		$compare = checkCompare($request->getAttribute('compare'));
		$suicide_no = Suicide::where('suicides_no', $compare, $suicides_no)->get();
		return $response->withJson($suicide_no);
	})->setArgument('compare', '=');

	$this->get('/getbypopulation/{number}[/{compare}]', function($request, $response, $args){
		$population = $request->getAttribute('number');
		$compare = checkCompare($request->getAttribute('compare'));
		$population = Suicide::where('population', $compare, $population)->get();
		return $response->withJson($population);
	})->setArgument('compare', '=');

	$this->get('/getbypib/{number}[/{compare}]', function($request, $response, $args){
		$gdp_per_capita = $request->getAttribute('number');
		$compare = checkCompare($request->getAttribute('compare'));
		$gdp_per_capita = Suicide::where('gdp_per_capita ($)', $compare, $gdp_per_capita)->get();
		return $response->withJson($gdp_per_capita);
	})->setArgument('compare', '=');

	$this->get('/getbygeneration/{generation}', function($request, $response){
		$generation = $request->getAttribute('generation');
		$suicide_generation = Suicide::where('generation', $generation)->get();
		return $response->withJson($suicide_generation);
	});
});

/*==============================
Assistant functions
==============================*/
function checkCompare($value){
	if($value == 'lower') $value = '<';
	else if($value == 'lowereq') $value = '<=';
	else if($value == 'higher') $value = '>';
	else if($value == 'highereq') $value = '>=';
	else $value = '=';

	return $value; 
}

/*=====================================
Funções para upload do CSV File
=====================================*/
function suicideme($file){
	$arr = array('country' => $file['country'], 'year' => $file['year'], 'sex' => $file['sex'], 'age' => $file['age'], 'suicides_no' => $file['suicides_no'], 'population' => $file['population'], 'suicides/100k pop' => $file['suicides/100k pop'], 'country-year' => $file['country-year'], 'HDI for year' => $file['HDI for year'], 'gdp_for_year ($)' => $file['gdp_for_year ($)'], 'gdp_per_capita ($)' => $file['gdp_per_capita ($)'], 'generation' => $file['generation'], 'created_at' => Carbon::now('America/Bahia')->toDateTimeString(), 'updated_at' => Carbon::now('America/Bahia')->toDateTimeString());
	try{
		$suicide = Suicide::create($arr);
		return true;
	}catch(Exception $e){
		return false;
	}
}

?>