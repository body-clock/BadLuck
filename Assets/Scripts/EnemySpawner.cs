using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	private GameObject enemy;

	public GameObject enemyPrefab;
	public Rigidbody2D rb;
	public float enemySpeed;
	public float maxEnemySpeed;

	public float spawnRate;
	public float maxSpawnRate;

	public float increaseRate;


	// Use this for initialization
	void Start () {
		//InvokeRepeating ("SpawnEnemyMethod", 0.00000001f, spawnRate);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Awake() {
		StartCoroutine ("SpawnEnemy");

	}

	void SpawnEnemyMethod() {
		Vector3 randomEnemyPos = new Vector3(Random.Range (-3f, 3f), transform.position.y, 4);
		enemy = Instantiate (enemyPrefab, randomEnemyPos, Quaternion.identity) as GameObject;
		rb = enemy.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector3 (0, -enemySpeed, 0);
	}

	IEnumerator SpawnEnemy() {

		yield return new WaitForSeconds (spawnRate);

		Vector3 randomEnemyPos = new Vector3(Random.Range (-3f, 3f), transform.position.y, 4);
		enemy = Instantiate (enemyPrefab, randomEnemyPos, Quaternion.identity) as GameObject;
		rb = enemy.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector3 (0, -enemySpeed, 0);

		if (spawnRate > maxSpawnRate) {
			spawnRate -= increaseRate * Time.deltaTime;
		} else if (spawnRate < maxSpawnRate) {
			spawnRate = maxSpawnRate;
		}

		if (enemySpeed < maxEnemySpeed) {
			enemySpeed += increaseRate * Time.deltaTime;
		} else if (enemySpeed > maxEnemySpeed) {
			enemySpeed = maxEnemySpeed;
		}
		StartCoroutine ("SpawnEnemy");
	}


		
}
