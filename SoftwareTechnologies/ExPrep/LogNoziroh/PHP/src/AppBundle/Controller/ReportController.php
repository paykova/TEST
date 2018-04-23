<?php

namespace AppBundle\Controller;

use AppBundle\Entity\Report;
use AppBundle\Form\ReportType;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class ReportController extends Controller
{
    /**
     * @param Request $request
     * @Route("/", name="index")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function index(Request $request)
    {
        $reports = $this
            ->getDoctrine()
            ->getRepository(Report::class)
            ->findAll();

//        $normalStatus = array_filter($reports, function ($report) {
//            return $report->getStatus() === 'Normal';
//        });
//
//        $warningStatus = array_filter($reports, function ($report) {
//            return $report->getStatus() === 'Warning';
//        });
//
//        $criticalStatus = array_filter($reports, function ($report) {
//            return $report->getStatus() === 'Critical';
//        });

        return $this->render('report/index.html.twig',
            [
                'reports' => $reports
            ]);
    }

    /**
     * @Route("/details/{id}", name="details")
     *
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function details($id, Request $request)
    {
        $report = $this
        ->getDoctrine()
        ->getRepository(Report::class)
        ->find($id);

        $form = $this->createForm(ReportType::class, $report);
        $form->handleRequest($request);

        return $this->render('report/details.html.twig',
            [
                'report' => $report
            ]);
    }

    /**
     * @param Request $request
     * @Route("/create", name="create")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function create(Request $request)
    {
        $report = new Report();
        $form = $this->createForm(ReportType::class, $report);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            $entityManager = $this->getDoctrine()->getManager();
            $entityManager->persist(@$report);
            $entityManager->flush();

            return $this->redirect('/');
        }

        return $this->render('report/create.html.twig',
            ['form' => $form->createView()]);
    }

    /**
     * @Route("/delete/{id}", name="delete")
     *
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function delete($id, Request $request)
    {
        $report = $this
            ->getDoctrine()
            ->getRepository(Report::class)
            ->find($id);

        $form = $this->createForm(ReportType::class, $report);
        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            $entityManager = $this->getDoctrine()->getManager();
            $entityManager->merge($report);
            $entityManager->flush();

            return $this->redirect('/');
        }


        return $this->render('report/delete.html.twig',
            [
                'report' => $report,
                'form' => $form->createView()
            ]);
    }
}
