extends ForLoopGD

@export var scene: PackedScene

func do() -> void:
	var root: Node = scene.instantiate()
	root.queue_free()
