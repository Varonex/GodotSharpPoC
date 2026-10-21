extends ForLoopGD

@export var packed: PackedByteArray

func do() -> void:
	Marshalls.raw_to_base64(packed)