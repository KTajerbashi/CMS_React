import React, { useEffect, useState } from "react";
import AccountService, { Account } from "./../../../services/accountService";
const HomeComponent: React.FC = () => {
  const [data, setData] = useState<Account[] | null>([
    {
      id: 1,
      firstName: "Kamran",
      lastName: "Tajerbashi",
      emailId: "Tajerbashi@mail.com",
    },
    {
      id: 1,
      firstName: "Kamran",
      lastName: "Tajerbashi",
      emailId: "Tajerbashi@mail.com",
    },
    {
      id: 1,
      firstName: "Kamran",
      lastName: "Tajerbashi",
      emailId: "Tajerbashi@mail.com",
    },
    {
      id: 1,
      firstName: "Kamran",
      lastName: "Tajerbashi",
      emailId: "Tajerbashi@mail.com",
    },
    {
      id: 1,
      firstName: "Kamran",
      lastName: "Tajerbashi",
      emailId: "Tajerbashi@mail.com",
    },
    {
      id: 1,
      firstName: "Kamran",
      lastName: "Tajerbashi",
      emailId: "Tajerbashi@mail.com",
    },
  ]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  console.log("AccountService ", AccountService);

  useEffect(() => {
    const fetchUser = async () => {
      try {
        await AccountService.get()
          .then((res) => {
            console.log("Response : ", res);
            const userData: Account[] = res.data;
            setData(userData);
          })
          .catch((err) => {
            console.log("Error : ", err);
          }); // Replace with dynamic user ID if needed
      } catch (err) {
        setError("Failed to load user.");
      } finally {
        setLoading(false);
      }
    };

    fetchUser();
  }, []);
  if (loading) return <p>Loading...</p>;
  if (error) return <p>{error}</p>;

  const getData = (): void => {
    console.log("Get Data");
  };

  return (
    <div className="container-fluid p-1 w-100">
      <div className="row">
        <div className="col-4">
          <button className="btn btn-primary" onClick={() => getData()}>
            GetData
          </button>
        </div>
      </div>
      <div className="row">
        <table className="table table-hover">
          <thead>
            <tr>
              <th>Id</th>
              <th>FirstName</th>
              <th>LastName</th>
              <th>EmailId</th>
            </tr>
          </thead>
          <tbody>
            {data &&
              data.map((item) => (
                <tr>
                  <td>{item.id}</td>
                  <td>{item.firstName}</td>
                  <td>{item.lastName}</td>
                  <td>{item.emailId}</td>
                </tr>
              ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default HomeComponent;
