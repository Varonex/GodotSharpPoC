@abstract class_name ForLoopGD extends Node

@export_range(0, 1, 1, "or_greater") var max_iterations: int = 1_000_000

func _ready() -> void:
	print("Début du script...")
	var start: int = Time.get_ticks_msec()
	var end: int

	for i in max_iterations:
		do()

	end = Time.get_ticks_msec()
	print("Fin du script... ", end - start, "ms")

@abstract func do() -> void
