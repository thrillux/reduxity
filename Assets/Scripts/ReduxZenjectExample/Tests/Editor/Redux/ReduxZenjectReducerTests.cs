﻿// using UnityEngine;
// using NUnit.Framework;

// namespace Reduxity.Example.Zenject.Tests {

// 	[TestFixture]
// 	public class ReducerTests {

// 		private App app_;
// 		private GameObject mockGameObject_;
// 		private State initialStateDump_;
// 		private State currentStateDump_;

// 		[SetUpAttribute]
// 		public void Init() {
// 			// initialize app
// 			app_ = new App();
// 			app_.Initialize();

// 			// set initial state object dump
// 			initialStateDump_ = new State {}.Initialize();

// 			// create empty game object
// 			mockGameObject_ = new GameObject();
// 		}

// 		[TearDownAttribute]
// 		public void Dispose() {
// 			app_ = null;
// 			initialStateDump_ = null;
// 			currentStateDump_ = null;
// 			mockGameObject_ = null;
// 		}

// 		[Test]
// 		public void Should_return_accurate_move_distance_from_move_reducer() {
// 			Action.Move mockMoveAction = new Action.Move {
// 				inputVelocity = Vector2.up.normalized,
// 				playerTransform = mockGameObject_.transform,
// 				fixedDeltaTime = 1.0f
// 			};
// 			App.Store.Dispatch(mockMoveAction);

// 			State currentState = GetCurrentState();
// 			Debug.Log(currentState.Movement.distance);
// 			Assert.IsTrue(currentState.Movement.isMoving);
// 			Assert.AreEqual(currentState.Movement.distance, Vector3.forward);
// 		}

// 		[Test]
// 		public void Should_stop_on_stop_action() {
// 			Action.Stop mockStopAction = new Action.Stop {};
// 			App.Store.Dispatch(mockStopAction);

// 			State currentState = GetCurrentState();
// 			Assert.IsFalse(currentState.Movement.isMoving);
// 		}

// 		private State GetCurrentState() {
// 			return App.Store.GetState();
// 		}
// 	}
// }