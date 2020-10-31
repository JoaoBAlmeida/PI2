<?php
	namespace App\Models;
	use Illuminate\Database\Eloquent\Model;

	class Suicide extends Model{
		protected $fillable = [
			'country', 'year', 'sex', 'age',
			'suicides_no', 'population', 'suicides/100k pop', 'country-year', 'HDI for year',
			'gdp_for_year ($)', 'gdp_per_capita ($)', 'generation',
			'updated_at', 'created_at'
		];
	}
?>