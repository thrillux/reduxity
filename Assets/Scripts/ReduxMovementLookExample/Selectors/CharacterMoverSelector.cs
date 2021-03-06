﻿using UnityEngine;

namespace Reduxity.Example.PlayerMovementLook {
	public static class CharacterMoverSelector {
		public static Vector3 GetMoveDistance(State state) {
			return state.Character.moveDistance;
		}

		public static Quaternion GetTurnRotation(State state) {
			return state.Character.transform.localRotation;
		}
	}
}
