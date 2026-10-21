extends ForLoopGD

@export var target: Node2D

func do() -> void:
	var pos: Vector2 = target.position
	pos.x += 1
	target.position = pos