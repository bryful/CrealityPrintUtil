using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace CrealityPrintUtil
{
	public class FilamentSystemPreset
	{
		public string type { get; set; }
		public string filament_id { get; set; }
		public string setting_id { get; set; }
		public string name { get; set; }
		public string from { get; set; }
		public string instantiation { get; set; }
		public string inherits { get; set; }
		public string activate_air_filtration { get; set; }
		public string activate_chamber_temp_control { get; set; }
		public string additional_cooling_fan_speed { get; set; }
		public string chamber_temperature { get; set; }
		public string close_fan_the_first_x_layers { get; set; }
		public string compatible_printers { get; set; }
		public string complete_print_exhaust_fan_speed { get; set; }
		public string cool_cds_fan_start_at_height { get; set; }
		public string cool_plate_temp { get; set; }
		public string cool_plate_temp_initial_layer { get; set; }
		public string cool_special_cds_fan_speed { get; set; }
		public string default_filament_colour { get; set; }
		public string during_print_exhaust_fan_speed { get; set; }
		public string enable_overhang_bridge_fan { get; set; }
		public string enable_pressure_advance { get; set; }
		public string eng_plate_temp { get; set; }
		public string eng_plate_temp_initial_layer { get; set; }
		public string epoxy_resin_plate_temp { get; set; }
		public string epoxy_resin_plate_temp_initial_layer { get; set; }
		public string fan_cooling_layer_time { get; set; }
		public string fan_max_speed { get; set; }
		public string fan_min_speed { get; set; }
		public string filament_cooling_final_speed { get; set; }
		public string filament_cooling_initial_speed { get; set; }
		public string filament_cooling_moves { get; set; }
		public string filament_cost { get; set; }
		public string filament_density { get; set; }
		public string filament_deretraction_speed { get; set; }
		public string filament_diameter { get; set; }
		public string filament_end_gcode { get; set; }
		public string filament_flow_ratio { get; set; }
		public string filament_is_support { get; set; }
		public string filament_load_time { get; set; }
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
		public string filament_shrink { get; set; }
		public string filament_soluble { get; set; }
		public string filament_start_gcode { get; set; }
		public string filament_toolchange_delay { get; set; }
		public string filament_type { get; set; }
		public string filament_unload_time { get; set; }
		public string filament_unloading_speed { get; set; }
		public string filament_unloading_speed_start { get; set; }
		public string filament_vendor { get; set; }
		public string filament_wipe { get; set; }
		public string filament_wipe_distance { get; set; }
		public string filament_z_hop { get; set; }
		public string filament_z_hop_types { get; set; }
		public string full_fan_speed_layer { get; set; }
		public string hot_plate_temp { get; set; }
		public string hot_plate_temp_initial_layer { get; set; }
		public string nozzle_temperature { get; set; }
		public string nozzle_temperature_initial_layer { get; set; }
		public string nozzle_temperature_range_high { get; set; }
		public string nozzle_temperature_range_low { get; set; }
		public string overhang_fan_speed { get; set; }
		public string overhang_fan_threshold { get; set; }
		public string pressure_advance { get; set; }
		public string reduce_fan_stop_start_freq { get; set; }
		public string required_nozzle_HRC { get; set; }
		public string slow_down_for_layer_cooling { get; set; }
		public string slow_down_layer_time { get; set; }
		public string slow_down_min_speed { get; set; }
		public string support_material_interface_fan_speed { get; set; }
		public string temperature_vitrification { get; set; }
		public string textured_plate_temp { get; set; }
		public string textured_plate_temp_initial_layer { get; set; }

	}

	public class FilamentSystemPresetCaption
	{
		public string type_cap { get; set; }
		static public string type_name() { return nameof(FilamentSystemPreset.type); }
		public string filament_id_cap { get; set; }
		static public string filament_id_name() { return nameof(FilamentSystemPreset.filament_id); }
		public string setting_id_cap { get; set; }
		static public string setting_id_name() { return nameof(FilamentSystemPreset.setting_id); }
		public string name_cap { get; set; }
		static public string name_name() { return nameof(FilamentSystemPreset.name); }
		public string from_cap { get; set; }
		static public string from_name() { return nameof(FilamentSystemPreset.from); }
		public string instantiation_cap { get; set; }
		static public string instantiation_name() { return nameof(FilamentSystemPreset.instantiation); }
		public string inherits_cap { get; set; }
		static public string inherits_name() { return nameof(FilamentSystemPreset.inherits); }
		public string activate_air_filtration_cap { get; set; }
		static public string activate_air_filtration_name() { return nameof(FilamentSystemPreset.activate_air_filtration); }
		public string activate_chamber_temp_control_cap { get; set; }
		static public string activate_chamber_temp_control_name() { return nameof(FilamentSystemPreset.activate_chamber_temp_control); }
		public string additional_cooling_fan_speed_cap { get; set; }
		static public string additional_cooling_fan_speed_name() { return nameof(FilamentSystemPreset.additional_cooling_fan_speed); }
		public string chamber_temperature_cap { get; set; }
		static public string chamber_temperature_name() { return nameof(FilamentSystemPreset.chamber_temperature); }
		public string close_fan_the_first_x_layers_cap { get; set; }
		static public string close_fan_the_first_x_layers_name() { return nameof(FilamentSystemPreset.close_fan_the_first_x_layers); }
		public string compatible_printers_cap { get; set; }
		static public string compatible_printers_name() { return nameof(FilamentSystemPreset.compatible_printers); }
		public string complete_print_exhaust_fan_speed_cap { get; set; }
		static public string complete_print_exhaust_fan_speed_name() { return nameof(FilamentSystemPreset.complete_print_exhaust_fan_speed); }
		public string cool_cds_fan_start_at_height_cap { get; set; }
		static public string cool_cds_fan_start_at_height_name() { return nameof(FilamentSystemPreset.cool_cds_fan_start_at_height); }
		public string cool_plate_temp_cap { get; set; }
		static public string cool_plate_temp_name() { return nameof(FilamentSystemPreset.cool_plate_temp); }
		public string cool_plate_temp_initial_layer_cap { get; set; }
		static public string cool_plate_temp_initial_layer_name() { return nameof(FilamentSystemPreset.cool_plate_temp_initial_layer); }
		public string cool_special_cds_fan_speed_cap { get; set; }
		static public string cool_special_cds_fan_speed_name() { return nameof(FilamentSystemPreset.cool_special_cds_fan_speed); }
		public string default_filament_colour_cap { get; set; }
		static public string default_filament_colour_name() { return nameof(FilamentSystemPreset.default_filament_colour); }
		public string during_print_exhaust_fan_speed_cap { get; set; }
		static public string during_print_exhaust_fan_speed_name() { return nameof(FilamentSystemPreset.during_print_exhaust_fan_speed); }
		public string enable_overhang_bridge_fan_cap { get; set; }
		static public string enable_overhang_bridge_fan_name() { return nameof(FilamentSystemPreset.enable_overhang_bridge_fan); }
		public string enable_pressure_advance_cap { get; set; }
		static public string enable_pressure_advance_name() { return nameof(FilamentSystemPreset.enable_pressure_advance); }
		public string eng_plate_temp_cap { get; set; }
		static public string eng_plate_temp_name() { return nameof(FilamentSystemPreset.eng_plate_temp); }
		public string eng_plate_temp_initial_layer_cap { get; set; }
		static public string eng_plate_temp_initial_layer_name() { return nameof(FilamentSystemPreset.eng_plate_temp_initial_layer); }
		public string epoxy_resin_plate_temp_cap { get; set; }
		static public string epoxy_resin_plate_temp_name() { return nameof(FilamentSystemPreset.epoxy_resin_plate_temp); }
		public string epoxy_resin_plate_temp_initial_layer_cap { get; set; }
		static public string epoxy_resin_plate_temp_initial_layer_name() { return nameof(FilamentSystemPreset.epoxy_resin_plate_temp_initial_layer); }
		public string fan_cooling_layer_time_cap { get; set; }
		static public string fan_cooling_layer_time_name() { return nameof(FilamentSystemPreset.fan_cooling_layer_time); }
		public string fan_max_speed_cap { get; set; }
		static public string fan_max_speed_name() { return nameof(FilamentSystemPreset.fan_max_speed); }
		public string fan_min_speed_cap { get; set; }
		static public string fan_min_speed_name() { return nameof(FilamentSystemPreset.fan_min_speed); }
		public string filament_cooling_final_speed_cap { get; set; }
		static public string filament_cooling_final_speed_name() { return nameof(FilamentSystemPreset.filament_cooling_final_speed); }
		public string filament_cooling_initial_speed_cap { get; set; }
		static public string filament_cooling_initial_speed_name() { return nameof(FilamentSystemPreset.filament_cooling_initial_speed); }
		public string filament_cooling_moves_cap { get; set; }
		static public string filament_cooling_moves_name() { return nameof(FilamentSystemPreset.filament_cooling_moves); }
		public string filament_cost_cap { get; set; }
		static public string filament_cost_name() { return nameof(FilamentSystemPreset.filament_cost); }
		public string filament_density_cap { get; set; }
		static public string filament_density_name() { return nameof(FilamentSystemPreset.filament_density); }
		public string filament_deretraction_speed_cap { get; set; }
		static public string filament_deretraction_speed_name() { return nameof(FilamentSystemPreset.filament_deretraction_speed); }
		public string filament_diameter_cap { get; set; }
		static public string filament_diameter_name() { return nameof(FilamentSystemPreset.filament_diameter); }
		public string filament_end_gcode_cap { get; set; }
		static public string filament_end_gcode_name() { return nameof(FilamentSystemPreset.filament_end_gcode); }
		public string filament_flow_ratio_cap { get; set; }
		static public string filament_flow_ratio_name() { return nameof(FilamentSystemPreset.filament_flow_ratio); }
		public string filament_is_support_cap { get; set; }
		static public string filament_is_support_name() { return nameof(FilamentSystemPreset.filament_is_support); }
		public string filament_load_time_cap { get; set; }
		static public string filament_load_time_name() { return nameof(FilamentSystemPreset.filament_load_time); }
		public string filament_loading_speed_cap { get; set; }
		static public string filament_loading_speed_name() { return nameof(FilamentSystemPreset.filament_loading_speed); }
		public string filament_loading_speed_start_cap { get; set; }
		static public string filament_loading_speed_start_name() { return nameof(FilamentSystemPreset.filament_loading_speed_start); }
		public string filament_max_volumetric_speed_cap { get; set; }
		static public string filament_max_volumetric_speed_name() { return nameof(FilamentSystemPreset.filament_max_volumetric_speed); }
		public string filament_minimal_purge_on_wipe_tower_cap { get; set; }
		static public string filament_minimal_purge_on_wipe_tower_name() { return nameof(FilamentSystemPreset.filament_minimal_purge_on_wipe_tower); }
		public string filament_multitool_ramming_cap { get; set; }
		static public string filament_multitool_ramming_name() { return nameof(FilamentSystemPreset.filament_multitool_ramming); }
		public string filament_multitool_ramming_flow_cap { get; set; }
		static public string filament_multitool_ramming_flow_name() { return nameof(FilamentSystemPreset.filament_multitool_ramming_flow); }
		public string filament_multitool_ramming_volume_cap { get; set; }
		static public string filament_multitool_ramming_volume_name() { return nameof(FilamentSystemPreset.filament_multitool_ramming_volume); }
		public string filament_notes_cap { get; set; }
		static public string filament_notes_name() { return nameof(FilamentSystemPreset.filament_notes); }
		public string filament_ramming_parameters_cap { get; set; }
		static public string filament_ramming_parameters_name() { return nameof(FilamentSystemPreset.filament_ramming_parameters); }
		public string filament_retract_before_wipe_cap { get; set; }
		static public string filament_retract_before_wipe_name() { return nameof(FilamentSystemPreset.filament_retract_before_wipe); }
		public string filament_retract_lift_above_cap { get; set; }
		static public string filament_retract_lift_above_name() { return nameof(FilamentSystemPreset.filament_retract_lift_above); }
		public string filament_retract_lift_below_cap { get; set; }
		static public string filament_retract_lift_below_name() { return nameof(FilamentSystemPreset.filament_retract_lift_below); }
		public string filament_retract_lift_enforce_cap { get; set; }
		static public string filament_retract_lift_enforce_name() { return nameof(FilamentSystemPreset.filament_retract_lift_enforce); }
		public string filament_retract_restart_extra_cap { get; set; }
		static public string filament_retract_restart_extra_name() { return nameof(FilamentSystemPreset.filament_retract_restart_extra); }
		public string filament_retract_when_changing_layer_cap { get; set; }
		static public string filament_retract_when_changing_layer_name() { return nameof(FilamentSystemPreset.filament_retract_when_changing_layer); }
		public string filament_retraction_length_cap { get; set; }
		static public string filament_retraction_length_name() { return nameof(FilamentSystemPreset.filament_retraction_length); }
		public string filament_retraction_minimum_travel_cap { get; set; }
		static public string filament_retraction_minimum_travel_name() { return nameof(FilamentSystemPreset.filament_retraction_minimum_travel); }
		public string filament_retraction_speed_cap { get; set; }
		static public string filament_retraction_speed_name() { return nameof(FilamentSystemPreset.filament_retraction_speed); }
		public string filament_shrink_cap { get; set; }
		static public string filament_shrink_name() { return nameof(FilamentSystemPreset.filament_shrink); }
		public string filament_soluble_cap { get; set; }
		static public string filament_soluble_name() { return nameof(FilamentSystemPreset.filament_soluble); }
		public string filament_start_gcode_cap { get; set; }
		static public string filament_start_gcode_name() { return nameof(FilamentSystemPreset.filament_start_gcode); }
		public string filament_toolchange_delay_cap { get; set; }
		static public string filament_toolchange_delay_name() { return nameof(FilamentSystemPreset.filament_toolchange_delay); }
		public string filament_type_cap { get; set; }
		static public string filament_type_name() { return nameof(FilamentSystemPreset.filament_type); }
		public string filament_unload_time_cap { get; set; }
		static public string filament_unload_time_name() { return nameof(FilamentSystemPreset.filament_unload_time); }
		public string filament_unloading_speed_cap { get; set; }
		static public string filament_unloading_speed_name() { return nameof(FilamentSystemPreset.filament_unloading_speed); }
		public string filament_unloading_speed_start_cap { get; set; }
		static public string filament_unloading_speed_start_name() { return nameof(FilamentSystemPreset.filament_unloading_speed_start); }
		public string filament_vendor_cap { get; set; }
		static public string filament_vendor_name() { return nameof(FilamentSystemPreset.filament_vendor); }
		public string filament_wipe_cap { get; set; }
		static public string filament_wipe_name() { return nameof(FilamentSystemPreset.filament_wipe); }
		public string filament_wipe_distance_cap { get; set; }
		static public string filament_wipe_distance_name() { return nameof(FilamentSystemPreset.filament_wipe_distance); }
		public string filament_z_hop_cap { get; set; }
		static public string filament_z_hop_name() { return nameof(FilamentSystemPreset.filament_z_hop); }
		public string filament_z_hop_types_cap { get; set; }
		static public string filament_z_hop_types_name() { return nameof(FilamentSystemPreset.filament_z_hop_types); }
		public string full_fan_speed_layer_cap { get; set; }
		static public string full_fan_speed_layer_name() { return nameof(FilamentSystemPreset.full_fan_speed_layer); }
		public string hot_plate_temp_cap { get; set; }
		static public string hot_plate_temp_name() { return nameof(FilamentSystemPreset.hot_plate_temp); }
		public string hot_plate_temp_initial_layer_cap { get; set; }
		static public string hot_plate_temp_initial_layer_name() { return nameof(FilamentSystemPreset.hot_plate_temp_initial_layer); }
		public string nozzle_temperature_cap { get; set; }
		static public string nozzle_temperature_name() { return nameof(FilamentSystemPreset.nozzle_temperature); }
		public string nozzle_temperature_initial_layer_cap { get; set; }
		static public string nozzle_temperature_initial_layer_name() { return nameof(FilamentSystemPreset.nozzle_temperature_initial_layer); }
		public string nozzle_temperature_range_high_cap { get; set; }
		static public string nozzle_temperature_range_high_name() { return nameof(FilamentSystemPreset.nozzle_temperature_range_high); }
		public string nozzle_temperature_range_low_cap { get; set; }
		static public string nozzle_temperature_range_low_name() { return nameof(FilamentSystemPreset.nozzle_temperature_range_low); }
		public string overhang_fan_speed_cap { get; set; }
		static public string overhang_fan_speed_name() { return nameof(FilamentSystemPreset.overhang_fan_speed); }
		public string overhang_fan_threshold_cap { get; set; }
		static public string overhang_fan_threshold_name() { return nameof(FilamentSystemPreset.overhang_fan_threshold); }
		public string pressure_advance_cap { get; set; }
		static public string pressure_advance_name() { return nameof(FilamentSystemPreset.pressure_advance); }
		public string reduce_fan_stop_start_freq_cap { get; set; }
		static public string reduce_fan_stop_start_freq_name() { return nameof(FilamentSystemPreset.reduce_fan_stop_start_freq); }
		public string required_nozzle_HRC_cap { get; set; }
		static public string required_nozzle_HRC_name() { return nameof(FilamentSystemPreset.required_nozzle_HRC); }
		public string slow_down_for_layer_cooling_cap { get; set; }
		static public string slow_down_for_layer_cooling_name() { return nameof(FilamentSystemPreset.slow_down_for_layer_cooling); }
		public string slow_down_layer_time_cap { get; set; }
		static public string slow_down_layer_time_name() { return nameof(FilamentSystemPreset.slow_down_layer_time); }
		public string slow_down_min_speed_cap { get; set; }
		static public string slow_down_min_speed_name() { return nameof(FilamentSystemPreset.slow_down_min_speed); }
		public string support_material_interface_fan_speed_cap { get; set; }
		static public string support_material_interface_fan_speed_name() { return nameof(FilamentSystemPreset.support_material_interface_fan_speed); }
		public string temperature_vitrification_cap { get; set; }
		static public string temperature_vitrification_name() { return nameof(FilamentSystemPreset.temperature_vitrification); }
		public string textured_plate_temp_cap { get; set; }
		static public string textured_plate_temp_name() { return nameof(FilamentSystemPreset.textured_plate_temp); }
		public string textured_plate_temp_initial_layer_cap { get; set; }
		static public string textured_plate_temp_initial_layer_name() { return nameof(FilamentSystemPreset.textured_plate_temp_initial_layer); }



		static public string[] Captions = new string[] {
			"type",
			"filament_id",
			"setting_id",
			"name",
			"from",
			"instantiation",
			"inherits",
			"activate_air_filtration",
			"activate_chamber_temp_control",
			"additional_cooling_fan_speed",
			"chamber_temperature",
			"close_fan_the_first_x_layers",
			"compatible_printers",
			"complete_print_exhaust_fan_speed",
			"cool_cds_fan_start_at_height",
			"cool_plate_temp",
			"cool_plate_temp_initial_layer",
			"cool_special_cds_fan_speed",
			"default_filament_colour",
			"during_print_exhaust_fan_speed",
			"enable_overhang_bridge_fan",
			"enable_pressure_advance",
			"eng_plate_temp",
			"eng_plate_temp_initial_layer",
			"epoxy_resin_plate_temp",
			"epoxy_resin_plate_temp_initial_layer",
			"fan_cooling_layer_time",
			"fan_max_speed",
			"fan_min_speed",
			"filament_cooling_final_speed",
			"filament_cooling_initial_speed",
			"filament_cooling_moves",
			"filament_cost",
			"filament_density",
			"filament_deretraction_speed",
			"filament_diameter",
			"filament_end_gcode",
			"filament_flow_ratio",
			"filament_is_support",
			"filament_load_time",
			"filament_loading_speed",
			"filament_loading_speed_start",
			"filament_max_volumetric_speed",
			"filament_minimal_purge_on_wipe_tower",
			"filament_multitool_ramming",
			"filament_multitool_ramming_flow",
			"filament_multitool_ramming_volume",
			"filament_notes",
			"filament_ramming_parameters",
			"filament_retract_before_wipe",
			"filament_retract_lift_above",
			"filament_retract_lift_below",
			"filament_retract_lift_enforce",
			"filament_retract_restart_extra",
			"filament_retract_when_changing_layer",
			"filament_retraction_length",
			"filament_retraction_minimum_travel",
			"filament_retraction_speed",
			"filament_shrink",
			"filament_soluble",
			"filament_start_gcode",
			"filament_toolchange_delay",
			"filament_type",
			"filament_unload_time",
			"filament_unloading_speed",
			"filament_unloading_speed_start",
			"filament_vendor",
			"filament_wipe",
			"filament_wipe_distance",
			"filament_z_hop",
			"filament_z_hop_types",
			"full_fan_speed_layer",
			"hot_plate_temp",
			"hot_plate_temp_initial_layer",
			"nozzle_temperature",
			"nozzle_temperature_initial_layer",
			"nozzle_temperature_range_high",
			"nozzle_temperature_range_low",
			"overhang_fan_speed",
			"overhang_fan_threshold",
			"pressure_advance",
			"reduce_fan_stop_start_freq",
			"required_nozzle_HRC",
			"slow_down_for_layer_cooling",
			"slow_down_layer_time",
			"slow_down_min_speed",
			"support_material_interface_fan_speed",
			"temperature_vitrification",
			"textured_plate_temp",
			"textured_plate_temp_initial_layer"
		};


		static public string[] GetValues(FilamentSystemPreset fup)
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
