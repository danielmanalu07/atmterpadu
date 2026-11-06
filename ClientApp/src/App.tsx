import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import "./App.css";
import { useEffect, useState } from "react";
import axios from "axios";

function Dashboard() {
  const [data, setData] = useState<any>(null);

  useEffect(() => {
    axios
      .get("http://localhost:5125/api/status")
      .then((response) => setData(response.data));
  }, []);

  if (!data) return <p>Loading...</p>;

  return (
    <div>
      <h1>Welcome, {data.application}</h1>
      <p>Role: {data.frontend}</p>
    </div>
  );
}

function About() {
  return (
    <div className="page">
      <h1>About</h1>
      <p>This page is rendered using React.</p>
    </div>
  );
}

function App() {
  return (
    <BrowserRouter>
      <nav className="navbar">
        <Link to="/">Dashboard</Link>
        <Link to="/about">About</Link>
      </nav>

      <Routes>
        <Route path="/" element={<Dashboard />} />
        <Route path="/about" element={<About />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
