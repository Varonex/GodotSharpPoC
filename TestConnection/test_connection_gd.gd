extends ForLoopGD

signal my_signal(a: int, b: String)

func do() -> void:
	my_signal.connect(_callback, CONNECT_ONE_SHOT)
	my_signal.emit(1, "a")

func _callback(_a: int, _b: String) -> void:
	pass