1private Rigidbody m_rb;
2
3// Use this for initialization
4void Start()
5{
6 m_rb = GetComponent<Rigidbody>();
7}
8
9void FixedUpdate()
10{
11 float movement = Input.GetAxis("Horizontal");
12 m_rb.AddForce(new Vector3(movement, 0.0F, 0.0F));
13}