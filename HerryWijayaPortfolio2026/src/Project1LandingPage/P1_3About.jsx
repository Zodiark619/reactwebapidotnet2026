export default function P1_3About({ data }) {
  const skills = data.skills.map((x) => {
    return (
      <article key={x.name} className="media">
        <div className="media-content">
          <div className="content">
            <p>
              <strong>{x.name}:</strong>
              <br />
              <progress
                className="progress is-primary"
                value={x.value}
                max="100"
              ></progress>
            </p>
          </div>
        </div>
      </article>
    );
  });

  return (
    <div>
      <section className="section" id="about">
        <div className="section-heading">
          <h3 className="title is-2">About Me</h3>
          <h4 className="subtitle is-5">{data.position2}</h4>
          <div className="container">
            <p>{data.description}</p>
          </div>
        </div>

        <div className="columns has-same-height is-gapless">
          <div className="column">
            <div className="card">
              <div className="card-content">
                <h3 className="title is-4">Profile</h3>

                <div className="content">
                  <table className="table-profile">
                    <tbody>
                      <tr>
                        <th colSpan="1"></th>
                        <th colSpan="2"></th>
                      </tr>
                      <tr>
                        <td>Address:</td>
                        <td>{data.address}</td>
                      </tr>
                      <tr>
                        <td>Phone:</td>
                        <td>{data.phone}</td>
                      </tr>
                      <tr>
                        <td>Email:</td>
                        <td>{data.email}</td>
                      </tr>
                    </tbody>
                  </table>
                </div>
                <br />
                <div className="buttons has-addons is-centered">
                  <a
                    href={data.github}
                    className="button is-link"
                    target="_blank"
                  >
                    Github
                  </a>
                  <a
                    href={data.linkedin}
                    className="button is-link"
                    target="_blank"
                  >
                    LinkedIn
                  </a>
                  <a
                    href={data.youtube}
                    className="button is-link"
                    target="_blank"
                  >
                    Youtube
                  </a>
                </div>
              </div>
            </div>
          </div>
          <div className="column">
            <div className="card">
              <div className="card-image">
                <figure className="image is-4by3">
                  <img
                    src="https://bulmatemplates.github.io/bulma-templates/images/first-post.png"
                    alt="Placeholder image"
                  />
                </figure>
              </div>
            </div>
          </div>
          <div className="column">
            <div className="card">
              <div className="card-content skills-content">
                <h3 className="title is-4">Skills</h3>
                <div className="content">{skills}</div>
              </div>
            </div>
          </div>
        </div>
      </section>
    </div>
  );
}
