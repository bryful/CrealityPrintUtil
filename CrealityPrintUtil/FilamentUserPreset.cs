using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CrealityPrintUtil
{
	public class FilamentUserPreset
	{
		public string activate_air_filtration { get; set; }
		public string activate_chamber_temp_control { get; set; }
		public string additional_cooling_fan_speed { get; set; }
		public string base_id { get; set; }
		public string chamber_temperature { get; set; }
		public string close_fan_the_first_x_layers { get; set; }
		public string complete_print_exhaust_fan_speed { get; set; }
		public string cool_cds_fan_start_at_height { get; set; }
		public string cool_special_cds_fan_speed { get; set; }
		public string customized_plate_temp { get; set; }
		public string customized_plate_temp_initial_layer { get; set; }
		public string dont_slow_down_outer_wall { get; set; }
		public string during_print_exhaust_fan_speed { get; set; }
		public string enable_special_area_additional_cooling_fan { get; set; }
		public string epoxy_resin_plate_temp { get; set; }
		public string epoxy_resin_plate_temp_initial_layer { get; set; }
		public string fan_cooling_layer_time { get; set; }
		public string fan_max_speed { get; set; }
		public string fan_min_speed { get; set; }
		public string filament_cooling_final_speed { get; set; }
		public string filament_cooling_initial_speed { get; set; }
		public string filament_cooling_moves { get; set; }
		public string filament_density { get; set; }
		public string filament_deretraction_speed { get; set; }
		public string filament_diameter { get; set; }
		public string filament_end_gcode { get; set; }
		public string filament_flow_ratio { get; set; }
		public string filament_is_support { get; set; }
		public string filament_loading_speed { get; set; }
		public string filament_loading_speed_start { get; set; }
		public string filament_max_volumetric_speed { get; set; }
		public string filament_minimal_purge_on_wipe_tower { get; set; }
		public string filament_multitool_ramming { get; set; }
		public string filament_multitool_ramming_flow { get; set; }
		public string filament_multitool_ramming_volume { get; set; }
		public string filament_notes { get; set; }
		public string filament_ramming_parameters { get; set; }
		public string filament_retract_before_wipe { get; set; }
		public string filament_retract_lift_above { get; set; }
		public string filament_retract_lift_below { get; set; }
		public string filament_retract_lift_enforce { get; set; }
		public string filament_retract_restart_extra { get; set; }
		public string filament_retract_when_changing_layer { get; set; }
		public string filament_retraction_length { get; set; }
		public string filament_retraction_minimum_travel { get; set; }
		public string filament_retraction_speed { get; set; }
		public string filament_settings_id { get; set; }
		public string filament_shrink { get; set; }
		public string filament_shrinkage_compensation_z { get; set; }
		public string filament_soluble { get; set; }
		public string filament_stamping_distance { get; set; }
		public string filament_stamping_loading_speed { get; set; }
		public string filament_start_gcode { get; set; }
		public string filament_toolchange_delay { get; set; }
		public string filament_type { get; set; }
		public string filament_unloading_speed { get; set; }
		public string filament_unloading_speed_start { get; set; }
		public string filament_vendor { get; set; }
		public string filament_wipe { get; set; }
		public string filament_wipe_distance { get; set; }
		public string filament_z_hop { get; set; }
		public string filament_z_hop_types { get; set; }
		public string from { get; set; }
		public string full_fan_speed_layer { get; set; }
		public string hot_plate_temp { get; set; }
		public string hot_plate_temp_initial_layer { get; set; }
		public string idle_temperature { get; set; }
		public string inherits { get; set; }
		public string name { get; set; }
		public string nozzle_temperature { get; set; }
		public string nozzle_temperature_initial_layer { get; set; }
		public string nozzle_temperature_range_high { get; set; }
		public string nozzle_temperature_range_low { get; set; }
		public string overhang_fan_speed { get; set; }
		public string overhang_fan_threshold { get; set; }
		public string pellet_flow_coefficient { get; set; }
		public string required_nozzle_HRC { get; set; }
		public string slow_down_layer_time { get; set; }
		public string slow_down_min_speed { get; set; }
		public string smart_cooling_zones { get; set; }
		public string temperature_vitrification { get; set; }
		public string textured_plate_temp { get; set; }
		public string textured_plate_temp_initial_layer { get; set; }
		public string version { get; set; }
	}

	public class FilamentUserPresetCaption
	{
		public string activate_air_filtration_cap { get; set; }
		static public string activate_air_filtration_name() { return nameof(FilamentUserPreset.activate_air_filtration); }
		public string activate_chamber_temp_control_cap { get; set; }
		static public string activate_chamber_temp_control_name() { return nameof(FilamentUserPreset.activate_chamber_temp_control); }
		public string additional_cooling_fan_speed_cap { get; set; }
		static public string additional_cooling_fan_speed_name() { return nameof(FilamentUserPreset.additional_cooling_fan_speed); }
		public string base_id_cap { get; set; }
		static public string base_id_name() { return nameof(FilamentUserPreset.base_id); }
		public string chamber_temperature_cap { get; set; }
		static public string chamber_temperature_name() { return nameof(FilamentUserPreset.chamber_temperature); }
		public string close_fan_the_first_x_layers_cap { get; set; }
		static public string close_fan_the_first_x_layers_name() { return nameof(FilamentUserPreset.close_fan_the_first_x_layers); }
		public string complete_print_exhaust_fan_speed_cap { get; set; }
		static public string complete_print_exhaust_fan_speed_name() { return nameof(FilamentUserPreset.complete_print_exhaust_fan_speed); }
		public string cool_cds_fan_start_at_height_cap { get; set; }
		static public string cool_cds_fan_start_at_height_name() { return nameof(FilamentUserPreset.cool_cds_fan_start_at_height); }
		public string cool_special_cds_fan_speed_cap { get; set; }
		static public string cool_special_cds_fan_speed_name() { return nameof(FilamentUserPreset.cool_special_cds_fan_speed); }
		public string customized_plate_temp_cap { get; set; }
		static public string customized_plate_temp_name() { return nameof(FilamentUserPreset.customized_plate_temp); }
		public string customized_plate_temp_initial_layer_cap { get; set; }
		static public string customized_plate_temp_initial_layer_name() { return nameof(FilamentUserPreset.customized_plate_temp_initial_layer); }
		public string dont_slow_down_outer_wall_cap { get; set; }
		static public string dont_slow_down_outer_wall_name() { return nameof(FilamentUserPreset.dont_slow_down_outer_wall); }
		public string during_print_exhaust_fan_speed_cap { get; set; }
		static public string during_print_exhaust_fan_speed_name() { return nameof(FilamentUserPreset.during_print_exhaust_fan_speed); }
		public string enable_special_area_additional_cooling_fan_cap { get; set; }
		static public string enable_special_area_additional_cooling_fan_name() { return nameof(FilamentUserPreset.enable_special_area_additional_cooling_fan); }
		public string epoxy_resin_plate_temp_cap { get; set; }
		static public string epoxy_resin_plate_temp_name() { return nameof(FilamentUserPreset.epoxy_resin_plate_temp); }
		public string epoxy_resin_plate_temp_initial_layer_cap { get; set; }
		static public string epoxy_resin_plate_temp_initial_layer_name() { return nameof(FilamentUserPreset.epoxy_resin_plate_temp_initial_layer); }
		public string fan_cooling_layer_time_cap { get; set; }
		static public string fan_cooling_layer_time_name() { return nameof(FilamentUserPreset.fan_cooling_layer_time); }
		public string fan_max_speed_cap { get; set; }
		static public string fan_max_speed_name() { return nameof(FilamentUserPreset.fan_max_speed); }
		public string fan_min_speed_cap { get; set; }
		static public string fan_min_speed_name() { return nameof(FilamentUserPreset.fan_min_speed); }
		public string filament_cooling_final_speed_cap { get; set; }
		static public string filament_cooling_final_speed_name() { return nameof(FilamentUserPreset.filament_cooling_final_speed); }
		public string filament_cooling_initial_speed_cap { get; set; }
		static public string filament_cooling_initial_speed_name() { return nameof(FilamentUserPreset.filament_cooling_initial_speed); }
		public string filament_cooling_moves_cap { get; set; }
		static public string filament_cooling_moves_name() { return nameof(FilamentUserPreset.filament_cooling_moves); }
		public string filament_density_cap { get; set; }
		static public string filament_density_name() { return nameof(FilamentUserPreset.filament_density); }
		public string filament_deretraction_speed_cap { get; set; }
		static public string filament_deretraction_speed_name() { return nameof(FilamentUserPreset.filament_deretraction_speed); }
		public string filament_diameter_cap { get; set; }
		static public string filament_diameter_name() { return nameof(FilamentUserPreset.filament_diameter); }
		public string filament_end_gcode_cap { get; set; }
		static public string filament_end_gcode_name() { return nameof(FilamentUserPreset.filament_end_gcode); }
		public string filament_flow_ratio_cap { get; set; }
		static public string filament_flow_ratio_name() { return nameof(FilamentUserPreset.filament_flow_ratio); }
		public string filament_is_support_cap { get; set; }
		static public string filament_is_support_name() { return nameof(FilamentUserPreset.filament_is_support); }
		public string filament_loading_speed_cap { get; set; }
		static public string filament_loading_speed_name() { return nameof(FilamentUserPreset.filament_loading_speed); }
		public string filament_loading_speed_start_cap { get; set; }
		static public string filament_loading_speed_start_name() { return nameof(FilamentUserPreset.filament_loading_speed_start); }
		public string filament_max_volumetric_speed_cap { get; set; }
		static public string filament_max_volumetric_speed_name() { return nameof(FilamentUserPreset.filament_max_volumetric_speed); }
		public string filament_minimal_purge_on_wipe_tower_cap { get; set; }
		static public string filament_minimal_purge_on_wipe_tower_name() { return nameof(FilamentUserPreset.filament_minimal_purge_on_wipe_tower); }
		public string filament_multitool_ramming_cap { get; set; }
		static public string filament_multitool_ramming_name() { return nameof(FilamentUserPreset.filament_multitool_ramming); }
		public string filament_multitool_ramming_flow_cap { get; set; }
		static public string filament_multitool_ramming_flow_name() { return nameof(FilamentUserPreset.filament_multitool_ramming_flow); }
		public string filament_multitool_ramming_volume_cap { get; set; }
		static public string filament_multitool_ramming_volume_name() { return nameof(FilamentUserPreset.filament_multitool_ramming_volume); }
		public string filament_notes_cap { get; set; }
		static public string filament_notes_name() { return nameof(FilamentUserPreset.filament_notes); }
		public string filament_ramming_parameters_cap { get; set; }
		static public string filament_ramming_parameters_name() { return nameof(FilamentUserPreset.filament_ramming_parameters); }
		public string filament_retract_before_wipe_cap { get; set; }
		static public string filament_retract_before_wipe_name() { return nameof(FilamentUserPreset.filament_retract_before_wipe); }
		public string filament_retract_lift_above_cap { get; set; }
		static public string filament_retract_lift_above_name() { return nameof(FilamentUserPreset.filament_retract_lift_above); }
		public string filament_retract_lift_below_cap { get; set; }
		static public string filament_retract_lift_below_name() { return nameof(FilamentUserPreset.filament_retract_lift_below); }
		public string filament_retract_lift_enforce_cap { get; set; }
		static public string filament_retract_lift_enforce_name() { return nameof(FilamentUserPreset.filament_retract_lift_enforce); }
		public string filament_retract_restart_extra_cap { get; set; }
		static public string filament_retract_restart_extra_name() { return nameof(FilamentUserPreset.filament_retract_restart_extra); }
		public string filament_retract_when_changing_layer_cap { get; set; }
		static public string filament_retract_when_changing_layer_name() { return nameof(FilamentUserPreset.filament_retract_when_changing_layer); }
		public string filament_retraction_length_cap { get; set; }
		static public string filament_retraction_length_name() { return nameof(FilamentUserPreset.filament_retraction_length); }
		public string filament_retraction_minimum_travel_cap { get; set; }
		static public string filament_retraction_minimum_travel_name() { return nameof(FilamentUserPreset.filament_retraction_minimum_travel); }
		public string filament_retraction_speed_cap { get; set; }
		static public string filament_retraction_speed_name() { return nameof(FilamentUserPreset.filament_retraction_speed); }
		public string filament_settings_id_cap { get; set; }
		static public string filament_settings_id_name() { return nameof(FilamentUserPreset.filament_settings_id); }
		public string filament_shrink_cap { get; set; }
		static public string filament_shrink_name() { return nameof(FilamentUserPreset.filament_shrink); }
		public string filament_shrinkage_compensation_z_cap { get; set; }
		static public string filament_shrinkage_compensation_z_name() { return nameof(FilamentUserPreset.filament_shrinkage_compensation_z); }
		public string filament_soluble_cap { get; set; }
		static public string filament_soluble_name() { return nameof(FilamentUserPreset.filament_soluble); }
		public string filament_stamping_distance_cap { get; set; }
		static public string filament_stamping_distance_name() { return nameof(FilamentUserPreset.filament_stamping_distance); }
		public string filament_stamping_loading_speed_cap { get; set; }
		static public string filament_stamping_loading_speed_name() { return nameof(FilamentUserPreset.filament_stamping_loading_speed); }
		public string filament_start_gcode_cap { get; set; }
		static public string filament_start_gcode_name() { return nameof(FilamentUserPreset.filament_start_gcode); }
		public string filament_toolchange_delay_cap { get; set; }
		static public string filament_toolchange_delay_name() { return nameof(FilamentUserPreset.filament_toolchange_delay); }
		public string filament_type_cap { get; set; }
		static public string filament_type_name() { return nameof(FilamentUserPreset.filament_type); }
		public string filament_unloading_speed_cap { get; set; }
		static public string filament_unloading_speed_name() { return nameof(FilamentUserPreset.filament_unloading_speed); }
		public string filament_unloading_speed_start_cap { get; set; }
		static public string filament_unloading_speed_start_name() { return nameof(FilamentUserPreset.filament_unloading_speed_start); }
		public string filament_vendor_cap { get; set; }
		static public string filament_vendor_name() { return nameof(FilamentUserPreset.filament_vendor); }
		public string filament_wipe_cap { get; set; }
		static public string filament_wipe_name() { return nameof(FilamentUserPreset.filament_wipe); }
		public string filament_wipe_distance_cap { get; set; }
		static public string filament_wipe_distance_name() { return nameof(FilamentUserPreset.filament_wipe_distance); }
		public string filament_z_hop_cap { get; set; }
		static public string filament_z_hop_name() { return nameof(FilamentUserPreset.filament_z_hop); }
		public string filament_z_hop_types_cap { get; set; }
		static public string filament_z_hop_types_name() { return nameof(FilamentUserPreset.filament_z_hop_types); }
		public string from_cap { get; set; }
		static public string from_name() { return nameof(FilamentUserPreset.from); }
		public string full_fan_speed_layer_cap { get; set; }
		static public string full_fan_speed_layer_name() { return nameof(FilamentUserPreset.full_fan_speed_layer); }
		public string hot_plate_temp_cap { get; set; }
		static public string hot_plate_temp_name() { return nameof(FilamentUserPreset.hot_plate_temp); }
		public string hot_plate_temp_initial_layer_cap { get; set; }
		static public string hot_plate_temp_initial_layer_name() { return nameof(FilamentUserPreset.hot_plate_temp_initial_layer); }
		public string idle_temperature_cap { get; set; }
		static public string idle_temperature_name() { return nameof(FilamentUserPreset.idle_temperature); }
		public string inherits_cap { get; set; }
		static public string inherits_name() { return nameof(FilamentUserPreset.inherits); }
		public string name_cap { get; set; }
		static public string name_name() { return nameof(FilamentUserPreset.name); }
		public string nozzle_temperature_cap { get; set; }
		static public string nozzle_temperature_name() { return nameof(FilamentUserPreset.nozzle_temperature); }
		public string nozzle_temperature_initial_layer_cap { get; set; }
		static public string nozzle_temperature_initial_layer_name() { return nameof(FilamentUserPreset.nozzle_temperature_initial_layer); }
		public string nozzle_temperature_range_high_cap { get; set; }
		static public string nozzle_temperature_range_high_name() { return nameof(FilamentUserPreset.nozzle_temperature_range_high); }
		public string nozzle_temperature_range_low_cap { get; set; }
		static public string nozzle_temperature_range_low_name() { return nameof(FilamentUserPreset.nozzle_temperature_range_low); }
		public string overhang_fan_speed_cap { get; set; }
		static public string overhang_fan_speed_name() { return nameof(FilamentUserPreset.overhang_fan_speed); }
		public string overhang_fan_threshold_cap { get; set; }
		static public string overhang_fan_threshold_name() { return nameof(FilamentUserPreset.overhang_fan_threshold); }
		public string pellet_flow_coefficient_cap { get; set; }
		static public string pellet_flow_coefficient_name() { return nameof(FilamentUserPreset.pellet_flow_coefficient); }
		public string required_nozzle_HRC_cap { get; set; }
		static public string required_nozzle_HRC_name() { return nameof(FilamentUserPreset.required_nozzle_HRC); }
		public string slow_down_layer_time_cap { get; set; }
		static public string slow_down_layer_time_name() { return nameof(FilamentUserPreset.slow_down_layer_time); }
		public string slow_down_min_speed_cap { get; set; }
		static public string slow_down_min_speed_name() { return nameof(FilamentUserPreset.slow_down_min_speed); }
		public string smart_cooling_zones_cap { get; set; }
		static public string smart_cooling_zones_name() { return nameof(FilamentUserPreset.smart_cooling_zones); }
		public string temperature_vitrification_cap { get; set; }
		static public string temperature_vitrification_name() { return nameof(FilamentUserPreset.temperature_vitrification); }
		public string textured_plate_temp_cap { get; set; }
		static public string textured_plate_temp_name() { return nameof(FilamentUserPreset.textured_plate_temp); }
		public string textured_plate_temp_initial_layer_cap { get; set; }
		static public string textured_plate_temp_initial_layer_name() { return nameof(FilamentUserPreset.textured_plate_temp_initial_layer); }
		public string version_cap { get; set; }
		static public string version_name() { return nameof(FilamentUserPreset.version); }


		static public string[] GetValues(FilamentUserPreset fup)
		{
			PropertyInfo[] p = fup.GetType().GetProperties();


			List<string> ret = new List<string>();

			foreach (PropertyInfo pi in p)
			{
				string s = "";
				string pn = p.GetType().Name;
				s += pn;
				s += "\t";
				s += fup.GetType().GetProperty(pn).GetValue(fup);
				s += "\r\n";
				ret.Add(s);
			}
			return ret.ToArray();
		}
	}

}
